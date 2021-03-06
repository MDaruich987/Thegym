﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemasIIITHEGYM.BussinesLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace SistemasIIITHEGYM
{
    public partial class AperturadeCajaEmpleado : System.Web.UI.Page
    {

        private static int id;
        private static string IdSuc;
        //cadena mili
        //SqlConnection conex = new SqlConnection("Data Source=DESKTOP-T2J3I6L;Initial Catalog=TheGym;Integrated Security=True");
        //cadena de conexion MICA
        //SqlConnection conex = new SqlConnection("Data Source = MICADARUICH\\SQLEXPRESS; Initial Catalog = TheGym; Integrated Security = True");
        //Cadena de Maxi
        SqlConnection conex = new SqlConnection(ConfigurationManager.ConnectionStrings["MiConec"].ConnectionString.ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToShortTimeString();
            //lblusuario.Text = "USUARIO";
            //id = "3";
            //lblmensajebienvenida.Text = Session["inicio"].ToString();
            //si efectivamente se ha iniciado sesión
            if (Session["inicio"] != null)
            {
                //declaramos una variale sesion para mantener el dato del usuario
                string usuario = (string)Session["Usuario"];
                lblusuario.Text = "Bienvenido/a " + (String)Session["inicio"];
                //lblusuario.Text = (string)Session["Usuario"];
                lblnombreusuario.Text = (string)Session["Ususario"];

                string cadena = (string)Session["Usuario"];

                TheGym k = new TheGym
                {
                    emailbusadm = cadena
                };
                DataTable dtid = new DataTable();

                dtid = k.GetAdmNomAp();

                lblnombreusuario.Text = (string)Session["inicio"];
                lblnombreusuario.Visible = true;

                cadena = dtid.Rows[0][0].ToString();

                id = Convert.ToInt32(cadena);

                lblsucursal.Text = "";
                lblestadocaja.Text = "Apertura";
                lblerror.Text = "";
                /*if (Request.Params["parametro"] != null)
                {
                    //para que el label capte el nombre y apellido enviado desde el form de acceso
                    lblmensajebienvenida.Text = "Bienvenido " + Request.Params["parametro"];
                }
                else
                {
                    //si no, muestra un mensaje de bienvenida solamente
                    lblmensajebienvenida.Text = "Bienvenido";
                }
                */

            }
            else
            {
                //si no se ha iniciado sesion me manda al inicio
                //Response.Redirect("InicioLogin.aspx");
            }

            CargaSucursal();
        }

        private void CargaSucursal()
        {

            TheGym k = new TheGym
            {
                IdEmpleadoCargaSuc = Convert.ToString(id)
            };
            DataTable dt = k.GetAllSucursal();
            if (dt.Rows.Count > 0)
            {
                lblsucursal.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblsucursal.Text = "3";
            }
            try
            {
                IdSuc = dt.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {

                lblerror.Text = "No sucursal " + ex.Message.ToString();
            }
            
        }



        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
           

            //CODIGO QUE YA ESTABA

            if (Convert.ToInt32(tbmonto.Text) > 0)
            {
                //verificamos que el monto sea postivo
                //bloque try-catch por cualquier error de la base de datos
                try
                {
                    try
                    {
                        //abrimos la conexion
                        conex.Open();
                        //creamos un comando sql, le pasamos la consulta a enviar a la base de datos y la conexion
                        SqlCommand com = new SqlCommand("select * from DetalleCaja where Fecha = convert(date, getdate())", conex);
                        //creamos un objetosql data adapter y le pasamos nuestro comando sql
                        SqlDataAdapter dap = new SqlDataAdapter(com);
                        //creamos un data table 
                        DataTable dat = new DataTable();
                        //para llenarlo con los datos de la tabla desde el data adapter
                        dap.Fill(dat);
                        //lblusuario.Text = dat.Rows[0][0].ToString()+ dat.Rows[0][1].ToString()+ dat.Rows[0][2].ToString();
                        //evaluamos si la consulta nos devuelve filas quiere decir que si hay un elemento que coincida
                        if (dat.Rows.Count >= 1)
                        {
                            //si al contar las filas del data table tenemos uno, el login es correcto
                            //verificamos si es un admin o empleado
                            if (dat.Rows[0][0].ToString() == "3" | dat.Rows[0][0].ToString() == "4" | dat.Rows[0][0].ToString() == "5" | dat.Rows[0][0].ToString() == "6")
                            {
                                lblerror.Text = "Ya se realizó la apertura de caja diaria.";
                            }
                            lblerror.Text = "Ya se realizó la apertura de caja diaria.";
                            lblerror.Visible = true;
                        }
                        else
                        {
                            if (tbmonto.Text == string.Empty)
                            {
                                lblerror.Text = "Se debe ingresar un monto";
                                lblerror.Visible = true;
                            }
                            else
                            {
                                TheGym k = new TheGym
                                {
                                    FK_empleado = Convert.ToString(id),
                                    Estadocaja = lblestadocaja.Text,
                                    FechaCaja = lblFecha.Text,
                                    Monto = tbmonto.Text
                                };

                                k.AperturaDeCaja();

                                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "$('#modal-default').modal('show');", true);
                                tbmonto.Enabled = false;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        lblerror.Text = ex.Message.ToString();

                    }
                }
                catch (Exception ex)
                {

                    lblerror.Text = ex.Message.ToString();
                }
            }
            else
            {
                //el monto no es positivo
                lblerror.Text = "El monto ingresado debe ser positivo";
            }
        }
    }
}
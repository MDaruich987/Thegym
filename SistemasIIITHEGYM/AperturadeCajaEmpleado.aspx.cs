﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemasIIITHEGYM;
using System.Data;
using System.Data.SqlClient;


namespace SistemasIIITHEGYM
{
    public partial class AperturadeCajaEmpleado : System.Web.UI.Page
    {

        private static string id;
        private static string IdSuc;
        //cadena mili
        SqlConnection conex = new SqlConnection("Data Source=DESKTOP-T2J3I6L;Initial Catalog=TheGym;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToShortTimeString();
            lblusuario.Text = "USUARIO";
            //lblmensajebienvenida.Text = Session["inicio"].ToString();
            //si efectivamente se ha iniciado sesión
            if (Session["inicio"] != null)
            {
                //declaramos una variale sesion para mantener el dato del usuario
                string usuario = (string)Session["Usuario"];
                lblusuario.Text = "Bienvenido/a " + (String)Session["inicio"];
                lblusuario.Text= (string)Session["Usuario"];
                lblnombreusuario.Text = "";
                lblsucursal.Text = "";
                lblestadocaja.Text = "";
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

            
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbmonto.Text) > 0)
            {
                //verificamos que el monto sea postivo
                //bloque try-catch por cualquier error de la base de datos
                try
                {
                    
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
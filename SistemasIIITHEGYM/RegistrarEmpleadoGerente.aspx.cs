﻿using SistemasIIITHEGYM.BussinesLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemasIIITHEGYM
{
    public partial class RegistrarEmpleadoGerente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           lblerror.Text = ("");

            if (!IsPostBack)
            {
                GetCargos();
                if (Session["inicio"] != null)
                {
                    //declaramos una variale sesion para mantener el dato del usuario
                    string usuario = (string)Session["Usuario"];
                    lblusuario.Text = "Bienvenido/a " + (String)Session["inicio"];
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
        }

        private void GetCargos()
        {
            TheGym k = new TheGym();
            DataTable dt = k.GetCargos();
            if (dt.Rows.Count > 0)
            {
                ddlcargo.DataValueField = "Id_cargo";
                ddlcargo.DataTextField = "Nombre";
                ddlcargo.DataSource = dt;
                ddlcargo.DataBind();
            }
        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            TheGym k = new TheGym
            {
                NombreEmpladoIns = tbnombre.Text,
                ApellidoEmpleadoIns = tbapellido.Text,
                FechaNacEmpleadoIns = Convert.ToDateTime(tbfechadenacimiento.Text),
                EmailEmpleadoIns = tbemail.Text,
                TelefEmpleadoIns = Convert.ToInt32(tbtelefono.Text),
                //falta todo lo de la direccion
                DNIEmpleadoIns = Convert.ToInt32(tbnumerodocumento.Text),
                FechaContEmpleadoIns = Convert.ToDateTime(tbfechacontratacion.Text),
                TitulEmpleadoIns = tbtitulo.Text,
                CargoEmpleadoIns = Convert.ToInt32(ddlcargo.SelectedItem.Value),
            };

            k.AddNewEmpleado();

            tbnombre.Text = string.Empty;
            tbapellido.Text = string.Empty;
            tbnumerodocumento.Text = string.Empty;
            tbemail.Text = string.Empty;
            tbfechacontratacion.Text = string.Empty;
            tbfechadenacimiento.Text = string.Empty;
            tbtelefono.Text = string.Empty;
            tbtitulo.Text = string.Empty;

            //faltamostrarmensajeemergente
        }
    }
}
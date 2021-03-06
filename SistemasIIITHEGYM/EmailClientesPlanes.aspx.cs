﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using SistemasIIITHEGYM.BussinesLayer;


namespace SistemasIIITHEGYM
{
    public partial class EmailClientesPlanes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["inicio"] != null)
            {
                //declaramos una variale sesion para mantener el dato del usuario
                string usuario = (string)Session["Usuario"];
                lblusuario.Text = "Bienvenido/a " + (String)Session["inicio"];

            }
            else
            {
                //si no se ha iniciado sesion me manda al inicio
                //Response.Redirect("InicioLogin.aspx");
            }

            TheGym k = new TheGym();
            DataTable dt = new DataTable();
            dt = k.GetCuotasVencidas();

            if(dt.Rows.Count>0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                GridView1.Visible = false;
            }

        

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {


            //Specify senders gmail address
            string SendersAddress = "thegyminfo@gmail.com";
            //Specify The Address You want to sent Email To(can be any valid email address)
            string ReceiversAddress = tbusuario0.Text;
            //Specify The password of gmial account u are using to sent mail(pw of sender@gmail.com)
            const string SendersPassword = "thegymsistema2018";
            //Write the subject of ur mail.el asunto
            const string subject = "THE GYM";
            //Write the contents of your mail. En la pantalla yo copie lo mismo que el codigo para que sepan que se va a enviar pero solo se puede cambiar desde aca abajo
            const string body = "Te estamos esperando. Presentando este mail obtene un 20% de descuento.";



            try
            {
                //we will use Smtp client which allows us to send email using SMTP Protocol
                //i have specified the properties of SmtpClient smtp within{}
                //gmails smtp server name is smtp.gmail.com and port number is 587
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SendersAddress, SendersPassword),
                    Timeout = 10000
                };

                //MailMessage represents a mail message
                //it is 4 parameters(From,TO,subject,body)

                MailMessage message = new MailMessage(SendersAddress, ReceiversAddress, subject, body);
                /*WE use smtp sever we specified above to send the message(MailMessage message)*/

                smtp.Send(message);
                lberror.Text = ("Message Sent Successfully");
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "$('#modal-default').modal('show');", true);

            }

            catch (Exception ex)
            {
                lberror.Text = ex.Message.ToString();
            }
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            tbusuario0.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[4].Text;
            tbusuario.Text = this.GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        }
    }
}
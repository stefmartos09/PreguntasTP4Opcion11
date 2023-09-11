using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Preguntas
{
    public partial class formCuestionario : System.Web.UI.Page
    {
        DataTable Datos = new DataTable();  
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CompletarFormulario();


        }
        private void CompletarFormulario()
        {
        
            lblPregunta1.Text = Datos.Rows[0]["Pregunta"].ToString();
            lblRpta1P1.Text = Datos.Rows[0]["Respuesta1"].ToString();
            lblRpta2P1.Text = Datos.Rows[0]["Respuesta2"].ToString();
            lblRpta3P1.Text = Datos.Rows[0]["Respuesta3"].ToString();
            lblPregunta2.Text = Datos.Rows[1]["Pregunta"].ToString();
            if (!IsPostBack)
            {
       
                ListItem rpta1 = new ListItem($"{Datos.Rows[1]["Respuesta1"].ToString()}", "1");
                ListItem rpta2 = new ListItem($"{Datos.Rows[1]["Respuesta2"].ToString()}", "2");
                ListItem rpta3 = new ListItem($"{Datos.Rows[1]["Respuesta3"].ToString()}", "3");

                chkListRptas2.Items.Add(rpta1);
                chkListRptas2.Items.Add(rpta2);
                chkListRptas2.Items.Add(rpta3);
            }
        }

        private void CargarDataTable(string[] Preguntas1, string[] preguntas2)
        {
            Datos.Columns.Clear();
            Datos.Columns.Add(new DataColumn("Pregunta", typeof(string)));
            Datos.Columns.Add(new DataColumn("Respuesta1", typeof(string)));
            Datos.Columns.Add(new DataColumn("Respuesta2", typeof(string)));
            Datos.Columns.Add(new DataColumn("Respuesta3", typeof(string)));
            Datos.Columns.Add(new DataColumn("Resultado1", typeof(int)));
            Datos.Columns.Add(new DataColumn("Resultado2", typeof(int)));
            Datos.Columns.Add(new DataColumn("Resultado3", typeof(int)));

            DataRow newRow = Datos.NewRow();
            newRow["Pregunta"] = Preguntas1[0];
            newRow["Respuesta1"] = Preguntas1[1];
            newRow["Respuesta2"] = Preguntas1[2];
            newRow["Respuesta3"] = Preguntas1[3];
            newRow["Resultado1"] = Preguntas1[4];
            newRow["Resultado2"] = Preguntas1[5];
            newRow["Resultado3"] = Preguntas1[6];
  
            Datos.Rows.Add(newRow);

            DataRow newRow2 = Datos.NewRow();
            newRow2["Pregunta"] = preguntas2[0];
            newRow2["Respuesta1"] = preguntas2[1];
            newRow2["Respuesta2"] = preguntas2[2];
            newRow2["Respuesta3"] = preguntas2[3];
            newRow2["Resultado1"] = preguntas2[4];
            newRow2["Resultado2"] = preguntas2[5];
            newRow2["Resultado3"] = preguntas2[6];

            Datos.Rows.Add(newRow2);
        }
        private void CargarDatos()
        {
            string ruta = Server.MapPath(".");
            if (File.Exists(ruta + "/datos.txt"))
            {
                StreamReader streamReader = new StreamReader(ruta + "/datos.txt");
                string[] lines = (streamReader.ReadToEnd()).Split('/');
                streamReader.Close();

                string pregunta1 = lines[0];
                string pregunta2 = lines[1];

                string[] respuestas1 = pregunta1.Split(';');
                string[] respuestas2 = pregunta2.Split(';');

                CargarDataTable(respuestas1, respuestas2 );

            }
            else
            {
                Response.Redirect("FormMenu.aspx");
            }
           
        }
        private void VerificarCuestionario()
        {
            int respuestaSeleccionadaPta1 = 0;
            int respuestaSeleccionadaPta2 = 0;
            int respuestaCorrectaPta1 = 0;
            int respuestaCorrectaPta2 = 0;
            int itemsChecked = 0;
            if (rbRpta1P1.Checked) respuestaSeleccionadaPta1 = 1;
           else if (rbRpta2P1.Checked) respuestaSeleccionadaPta1 = 2;           
           else if (rbRpta3P1.Checked) respuestaSeleccionadaPta1 = 3;

            if (Convert.ToInt32(Datos.Rows[0]["Resultado1"].ToString()) == 1) respuestaCorrectaPta1 = 1;
            else if (Convert.ToInt32(Datos.Rows[0]["Resultado2"].ToString()) == 1) respuestaCorrectaPta1 = 2;
            else if (Convert.ToInt32(Datos.Rows[0]["Resultado3"].ToString()) == 1) respuestaCorrectaPta1 = 3;

            if(respuestaSeleccionadaPta1 == respuestaCorrectaPta1)
            {
                lblRptaPregunta1.ForeColor = Color.Green;
                lblRptaPregunta1.Text = "Respuesta Correcta!";
            }
            else
            {
                lblRptaPregunta1.ForeColor = Color.Red;
                lblRptaPregunta1.Text = "Respuesta Incorrecta!";
            }

       
            if (chkListRptas2.Items[0].Selected) itemsChecked = itemsChecked + 1;
            if (chkListRptas2.Items[1].Selected) itemsChecked = itemsChecked + 1;
            if (chkListRptas2.Items[2].Selected) itemsChecked = itemsChecked + 1;

            if (Convert.ToInt32(Datos.Rows[1]["Resultado1"].ToString()) == 1) respuestaCorrectaPta2 = respuestaCorrectaPta2+1;
            if (Convert.ToInt32(Datos.Rows[1]["Resultado2"].ToString()) == 2) respuestaCorrectaPta2 = respuestaCorrectaPta2+1;
            if (Convert.ToInt32(Datos.Rows[1]["Resultado3"].ToString()) == 3) respuestaCorrectaPta2 = respuestaCorrectaPta2+1;

            if (chkListRptas2.Items[0].Selected && Convert.ToInt32(Datos.Rows[1]["Resultado1"].ToString()) == 1)
            {
                respuestaSeleccionadaPta2 = respuestaSeleccionadaPta2 +1;
            }
        
            if (chkListRptas2.Items[1].Selected && Convert.ToInt32(Datos.Rows[1]["Resultado2"].ToString()) == 2)
            {
                respuestaSeleccionadaPta2 = respuestaSeleccionadaPta2 + 1;
            }

            if (chkListRptas2.Items[2].Selected && Convert.ToInt32(Datos.Rows[1]["Resultado3"].ToString()) == 3)
            {
                respuestaSeleccionadaPta2 = respuestaSeleccionadaPta2 + 1;
            }

            if (respuestaSeleccionadaPta2 == respuestaCorrectaPta2 && itemsChecked == respuestaCorrectaPta2)
            {
                lblRptaPregunta2.ForeColor = Color.Green;
                lblRptaPregunta2.Text = "Respuesta Correcta!";
            }
           else if (respuestaSeleccionadaPta2 == 0)
            {
                lblRptaPregunta2.ForeColor = Color.Red;
                lblRptaPregunta2.Text = "Respuesta Incorrecta!";
            }
            else
            {
                lblRptaPregunta2.ForeColor = Color.Orange;
                lblRptaPregunta2.Text = "Respuesta Parcialmente Correcta!";
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
        
            VerificarCuestionario();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormMenu.aspx");
        }
    }
}
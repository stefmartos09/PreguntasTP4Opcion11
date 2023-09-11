using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Preguntas
{
    public partial class formConfigurarPregutnas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool Validar()
        {
          
                if(rbRpta1P1.Checked == false && rbRpta2P1.Checked == false && rbRpta3P1.Checked == false)
                {
                    lblRespuesta.Text = "Debe Seleccionar una respuesta correcta de la pregunta 1";
                    lblRespuesta.ForeColor = Color.Red;
                    return false;
                }
                if (chkRpta1P2.Checked == false && chkRpta2P2.Checked == false && chkRpta3P2.Checked == false)
                {
                    lblRespuesta.Text = "Debe Seleccionar al menos una respuesta correcta de la pregunta 2";
                    lblRespuesta.ForeColor = Color.Red;
                    return false;
                }
                return true;
           
        }
        private void GuardarDatos()
        {

            if (!Validar()) return;

            string Ruta = Server.MapPath(".");

            StreamWriter streamWriter = new StreamWriter($"{Ruta}/datos.txt");
            streamWriter.WriteLine(txtpregunta1.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP1R1.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP1R2.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP1R3.Text.Trim() + ";");
            if(rbRpta1P1.Checked) streamWriter.WriteLine("1" + ";"); else streamWriter.WriteLine("0" + ";");
            if (rbRpta2P1.Checked) streamWriter.WriteLine("2" + ";"); else streamWriter.WriteLine("0" + ";");
            if (rbRpta3P1.Checked) streamWriter.WriteLine("3" + ";/"); else streamWriter.WriteLine("0" + ";/");
            streamWriter.WriteLine(txtpregunta2.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP2R1.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP2R2.Text.Trim() + ";");
            streamWriter.WriteLine(txtrespuestaP2R3.Text.Trim() + ";");
            if (chkRpta1P2.Checked) streamWriter.WriteLine("1" + ";"); else streamWriter.WriteLine("0" + ";");
            if (chkRpta2P2.Checked) streamWriter.WriteLine("2" + ";"); else streamWriter.WriteLine("0" + ";");
            if (chkRpta3P2.Checked) streamWriter.WriteLine("3" + ";"); else streamWriter.WriteLine("0" + ";");
            streamWriter.Close();
            lblRespuesta.ForeColor = Color.Green;
            lblRespuesta.Text = $"Agregado, ruta de datos.txt {Ruta} .";
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormMenu.aspx");
        }
    }
}
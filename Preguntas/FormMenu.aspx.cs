using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Preguntas
{
    public partial class FormMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCuestionario_Click(object sender, EventArgs e)
        {
            Response.Redirect("formConfigurarPregutnas.aspx");
        }

        protected void btnVerCuestionario_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCuestionario.aspx");
        }
    }
}
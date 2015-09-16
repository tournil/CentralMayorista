using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServicesDemoMovil
{
    public partial class frmAdmonNoticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            dsNoticias.InsertParameters["strImagenNoticia"].DefaultValue = "http://adnsoftware.com.co";
            dsNoticias.InsertParameters["strTituloNoticia"].DefaultValue = "Titulo noticia";
            dsNoticias.Insert();
        }
    }
}
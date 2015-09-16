using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemoMovil
{
    /// <summary>
    /// Descripción breve de Service1
    /// </summary>
    [WebService(Namespace = "http://adnsoftware.com.co/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string ObtenerUbicaciones(string strIdMovil)
        {
            General objGeneral = new General();
            System.Data.DataSet dtsMisAmigos = objGeneral.ObtenerUbicacionAmigos(strIdMovil);
            if (dtsMisAmigos != null)
            {
                return dtsMisAmigos.GetXml();
            }
            return "";
        }

        [WebMethod]
        public string ListarNoticias()
        {
            General objGeneral = new General();
            System.Data.DataSet dtsNoticias = objGeneral.ListarNoticias();
            if (dtsNoticias != null)
            {
                return dtsNoticias.GetXml();
            }
            return "";
        }
        [WebMethod]
        public string ListarEventos()
        {
            General objGeneral = new General();
            System.Data.DataSet dtsEventos = objGeneral.ListarEventos();
            if (dtsEventos != null)
            {
                return dtsEventos.GetXml();
            }
            return "";

        }
    }
}
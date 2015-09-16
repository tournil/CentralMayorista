using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using Microsoft.WindowsAzure.Storage.Blob;
using WebServicesDemoMovil.Entidades;


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
        private General _objGeneral;
        [WebMethod]
        public string ObtenerUbicaciones(string strIdMovil)
        {
            _objGeneral = new General();
            var dtsMisAmigos = _objGeneral.ObtenerUbicacionAmigos(strIdMovil);
            return dtsMisAmigos != null ? dtsMisAmigos.GetXml() : "";
        }

        [WebMethod]
        public string ListarNoticias()
        {
            _objGeneral = new General();
            var dtsNoticias = _objGeneral.ListarNoticias();
            return dtsNoticias != null ? dtsNoticias.GetXml() : "";
        }
        [WebMethod]
        public string ListarEventos()
        {
            _objGeneral = new General();
            var dtsEventos = _objGeneral.ListarEventos();
            return dtsEventos != null ? dtsEventos.GetXml() : "";
        }

        [WebMethod]
        public string GuardarAtencion(Solicitudes solicitud)
        {
            var adjuntos = new Adjuntos();
            var archivo = adjuntos.GuardarArchivo(solicitud.ImagenBytes, "tucma", solicitud.NombreImagen);
            solicitud.ImagenUrl = archivo.Uri.ToString();
            _objGeneral = new General();
            var dtsGuardado = _objGeneral.GuardarAtencion(solicitud);
            return dtsGuardado != null ? dtsGuardado.GetXml() : "";
        }
    }
}
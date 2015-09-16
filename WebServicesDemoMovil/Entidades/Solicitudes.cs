using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesDemoMovil.Entidades
{
    public class Solicitudes
    {
        public int Id { get; set; }
        public string ImagenUrl { get; set; }
        public string NombreImagen { get; set; }
        public string Solicitud { get; set; }
        public int AreaSolicitud { get; set; }
        public bool Activa { get; set; }
        public bool Atendido { get; set; }
        public int AtendidoPor { get; set; }
        public int SolicitadoPor { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaAtencion { get; set; }
        public byte[] ImagenBytes { get; set; }
    }
}
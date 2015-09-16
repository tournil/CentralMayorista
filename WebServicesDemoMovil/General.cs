using System;
using System.Data;
using System.Data.SqlClient;
using ADN.AccesoDatos;
using WebServicesDemoMovil.Entidades;


namespace WebServicesDemoMovil
{
    public class General
    {
        public DataSet ObtenerUbicacionAmigos(string strIdMovil)
        {
            var datos = new Datos();
            SqlParameter[] sqlParameters1 =
            { new SqlParameter("@ID_MOVIL", strIdMovil)
            };

            try
            {
                var dataSet = datos.EjecutarSP("spObtenerMovilesAmigos", sqlParameters1);
                return dataSet.Tables[0].Rows.Count > 0 ? dataSet : null;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public DataSet ListarNoticias()
        {
            Datos datos = new Datos();

            try
            {
                DataSet dataSet = datos.EjecutarSP("spCMAListarNoticias", null);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet;
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataSet ListarEventos()
        {
            Datos datos = new Datos();
            try
            {
                DataSet dtsEventos = datos.EjecutarSP("spCMAListarEventos", null);
                if (dtsEventos.Tables[0].Rows.Count > 0)
                {
                    return dtsEventos;
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool GuardarComentarios(Solicitudes entidad)
        {
            return true;
        }

        internal DataSet GuardarAtencion(Solicitudes solicitud)
        {
            var datos = new Datos();
            SqlParameter[] sqlParameters1 =
            { new SqlParameter("@strImagenSolicitud", solicitud.ImagenUrl),
                new SqlParameter("@strDescripcionSolicitud", solicitud.Solicitud),
                new SqlParameter("@idAreaSolicitud", solicitud.AreaSolicitud),
                new SqlParameter("@logActiva", solicitud.Activa),
                new SqlParameter("@logAtendido", solicitud.Atendido),
                new SqlParameter("@IdAtendido", solicitud.AtendidoPor),
                new SqlParameter("@IdSolicitado", solicitud.SolicitadoPor),
                new SqlParameter("@dtmFechaSolicitud", solicitud.FechaSolicitud),
                new SqlParameter("@@dtmFechaAtencion", solicitud.FechaAtencion),
            };
            try
            {
                var dataSet = datos.EjecutarSP("spCMACrearSolicitud", sqlParameters1);
                return dataSet.Tables[0].Rows.Count > 0 ? dataSet : null;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
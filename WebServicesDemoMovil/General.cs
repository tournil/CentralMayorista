using System;
using System.Data;
using System.Data.SqlClient;
using ADN.AccesoDatos;


namespace WebServicesDemoMovil
{
    public class General
    {
        public DataSet ObtenerUbicacionAmigos(string strIdMovil)
        {
            Datos datos = new Datos();
            SqlParameter[] sqlParameters1 = new SqlParameter[] { 
                new SqlParameter("@ID_MOVIL", strIdMovil)
            
            
            
            };

            try
            {
                DataSet dataSet = datos.EjecutarSP("spObtenerMovilesAmigos", sqlParameters1);
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
                if(dtsEventos.Tables[0].Rows.Count>0)
                {
                    return dtsEventos;
                }
                return null;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        public bool GuardarComentarios()
        {
            
        }
    }
}
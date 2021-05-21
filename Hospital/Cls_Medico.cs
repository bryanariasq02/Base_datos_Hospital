using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    public class Cls_Medico
    {

        Cls_Conexion objconexion = new Cls_Conexion();
        SqlCommand cmd = new SqlCommand();

        public DataSet consulta_medico(string pid_medico)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_Medico";
                cmd.Parameters.Add("@pId_Medico", pid_medico);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public bool guardar_medico(string pid_medico, string pnom_medico, string pesp_medico)
        {
            try
            {
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
        public bool eliminar_medico(string pid_medico)
        {
            try
            {
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

    }
}
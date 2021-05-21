using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Hospital
{
    public class Cls_Paciente
    {
        Cls_Conexion objconexion = new Cls_Conexion();
        SqlCommand cmd = new SqlCommand();

        public DataSet consulta_paciente(string pid_paciente)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_paciente";
                cmd.Parameters.Add("@pId_Paciente", pid_paciente);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(Exception error)      
            {
                throw new Exception(error.Message);
            }
        }
        public bool guardar_paciente(string pid_paciente, string pnom_paciente,string ptel_paciemte,string pdir_paciente)
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
        public bool eliminar_paciente(string pid_paciente)
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
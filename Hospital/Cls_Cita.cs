using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hospital
{
    public class Cls_Cita
    {
        Cls_Conexion objconexion = new Cls_Conexion();
        SqlCommand cmd = new SqlCommand();


        public DataSet concultar_cita(string pcod_cita)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_cita";
                cmd.Parameters.Add("@pCod_Cita", pcod_cita);
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
    
        public bool guardat_cita(string pcod_cita,string pfecha,string phora, string pconsultorio, string pidpaciente, string pidmedico, int pval, string pobservaciones)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_cita";
                cmd.Parameters.Add("@pCod_Cita", pcod_cita);
                cmd.Parameters.Add("@pFecha", pfecha);
                cmd.Parameters.Add("@pHora", phora);
                cmd.Parameters.Add("@pConsultorio", pconsultorio);
                cmd.Parameters.Add("@pId_Paciente", pidpaciente);
                cmd.Parameters.Add("@pId_Medico", pidmedico);
                cmd.Parameters.Add("@pValor", pval);
                cmd.Parameters.Add("@pObservaciones", pobservaciones);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception error)
            {
            throw new Exception(error.Message);

            }
        }
        public bool anular_cita(string pcod_cita)
        {
            try
            {
                cmd.Connection = objconexion.abrir_base();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_anular_cita";
                cmd.Parameters.Add("@pCod_Cita", pcod_cita);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Hospital
{
    public class Cls_Conexion
    {
        
        public SqlConnection abrir_base()
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = "data source = 312C-31\\INGENIERIA;database=Hospital;user id=sa;pwd=1";
                cnn.Open();
                return cnn;
            }
            catch(Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
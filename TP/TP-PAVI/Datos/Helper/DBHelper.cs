using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TP_PAVI.Datos
{
    class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();

        private DBHelper()
        {
            string_conexion = @"Data Source=M26\SQLEXPRESS;Initial Catalog=BT3;Integrated Security=True";
        }
        
        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public int EjecutarSQL(string strSQL)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //Comienzo de transacción
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSQL;
                cmd.Transaction = t;
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }
            return afectadas;
        }

        public DataTable ConsultaSQL (string strSQL)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
            

        }

        public DataTable ConsultaSQLConParametros (string strSQL, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;

                for (int i = 0; i < prs.Length; i++)
                if (prs[i] != null)
                {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                }
                
                
                
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }
        private void CloseConnection (SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }


        //VER COMO SE IMPLEMENTA EjecutarSQL PARA CAMBIAR TODO A UN SOLO MÉTODO
        public int EjecutarSQL2(string strSql, Dictionary<string, object> prs = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }
            return rtdo;
        }

        //VER COMO SE IMPLEMENTA ConsultaSQL PARA CAMBIAR TODO A UN SOLO MÉTODO
        public DataTable ConsultaSQL2(string strSql, Dictionary<string, object> prs = null)
        {

            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {

                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }
        }

    }
}

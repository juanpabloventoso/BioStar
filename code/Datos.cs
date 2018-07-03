using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using System.IO;
namespace Persistence
{
    public class Database
    {
        System.Data.SqlClient.SqlConnection _cn;
        System.Data.SqlClient.SqlCommand _cmd;
        System.Data.SqlClient.SqlDataAdapter _da;
        System.Data.DataSet _ds;
        System.Data.DataTable _tabla;
        public static readonly Database Instance = new Database();


        public Database()
        {
            _cn = new System.Data.SqlClient.SqlConnection();
            _cmd = new System.Data.SqlClient.SqlCommand();
            _ds = new System.Data.DataSet();
        }

        public System.Data.DataTable Tabla { get { return _tabla; } }

        public void conectar()
        {
            string connectionString = "Data Source = LOCALHOST\\SQLEXPRESS; Initial Catalog = BioSoft; Integrated Security = SSPI";
            _cn.ConnectionString = connectionString;
            _cn.Open();
        }

        public void Desconectar()
        {
            _cn.Close();
        }

        public int Ejecutar_Sentencia(string strSQL)
        {
            _cmd.Connection = _cn;
            _cmd.CommandText = strSQL;
            _cmd.ExecuteNonQuery();
            if (strSQL.ToLower().Contains("INSERT"))
            {
                _cmd.CommandText = "SELECT @@IDENTITY";
                return int.Parse(_cmd.ExecuteScalar().ToString());
            }
            return 0;
        }


        public int Ejecutar_Sentencia_Imagen(string strSQL, byte[] Imagen)
        {
            _cmd.Connection = _cn;
            _cmd.CommandText = strSQL;
            _cmd.Parameters.Add (new SqlParameter("@Imagen",SqlDbType.Image)).Value = Imagen;
            _cmd.ExecuteNonQuery();
            _cmd.CommandText =  "SELECT @@IDENTITY"; 
            return int.Parse(_cmd.ExecuteScalar().ToString());
        }


        public void Ejecutar_Consulta(string strSQL)
        {
            _da = new System.Data.SqlClient.SqlDataAdapter(strSQL, _cn);
            _da.Fill(_ds);
            _tabla = _ds.Tables[0];
        }

        public MemoryStream Ejecutar_Consulta_Imagen(string strSQL)
        {
            _da = new System.Data.SqlClient.SqlDataAdapter(strSQL, _cn);
            _cmd.Connection = _cn;
            _cmd.CommandText = strSQL;
            byte[] b = (byte[])_cmd.ExecuteScalar();
            MemoryStream mem = new MemoryStream(b);
            _da.Fill(_ds); // CARGA EL DATA SET CON LO QUE TENIA EL ADAPTER
            _tabla = _ds.Tables[0];
            return mem;
        }
    }
}
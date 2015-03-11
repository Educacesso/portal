using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PortalEducacesso.dao
{
    public class ConnectionFactory
    {
        private SqlConnection conn;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public SqlConnection getConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=localhost; Initial Catalog=educacesso; Integrated Security=True");
                conn.Open();
                return conn;
            }
            catch (SqlException erro)
            {
                throw new NullReferenceException("Banco de dados não encontrado.");
            }
        }  
    }
}
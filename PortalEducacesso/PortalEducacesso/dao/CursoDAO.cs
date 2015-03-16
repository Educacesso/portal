using PortalEducacesso.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PortalEducacesso.dao
{
    public class CursoDAO
    {
        // Atributos de referência
        private SqlConnection conn;
        private SqlCommand cmd;

        public void cadastrar(Curso curso)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String sql = "INSERT INTO curso VALUES(@nmCurso, @dsCurso, @ctCurso)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@nmCurso", curso.Nome));
                cmd.Parameters.Add(new SqlParameter("@dsCurso", curso.Descricao));
                cmd.Parameters.Add(new SqlParameter("@ctCurso", curso.Categoria));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException erro)
            {
                throw new InvalidExpressionException("Erro ao cadastrar dados\nErro: " + erro.Message);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dados
{
    public class CursoDB
    {
        private static SQLiteConnection sqliteConnection;
        public CursoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Curso curso)
        {
            try
            {
                string sql = "INSERT INTO curso_tb " + "(Id, Cod_curso ,Nome, Dt_inclusao, Dt_alteracao)" + "values(@Id, @Cod_curso ,@Nome, @Dt_inclusao, @Dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", curso.Id);
                    cmd.Parameters.AddWithValue("@Cod_curso", curso.Cod_curso);
                    cmd.Parameters.AddWithValue("@Nome", curso.Nome);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", curso.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", curso.Dt_alteracao);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ConsultarTudo()
        {
            DataTable dat = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT id,");
            sb.Append(" cod_curso,");
            sb.Append(" nome,");
            sb.Append(" dt_inclusao,");
            sb.Append(" dt_alteracao");
            sb.Append("FROM curso_tb");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dat);
            }
            return dat;
        }

        public List<Curso> ConsultarList()
        {
            SQLiteDataReader dr = null;
            List<Curso> curso = new List<Curso>();

            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT id, ");
            sb.Append("        cod_curso, ");
            sb.Append("        nome, ");
            sb.Append("        dt_inclusao,");
            sb.Append("        dt_alteracao");
            sb.Append("  FROM  curso_tb ");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                dr = cmd.ExecuteReader();
            }

            if (dr.HasRows)
            {
                {
                    while (dr.Read())
                    {
                        Curso p = new Curso()
                        {
                            Id = (dr[0] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Cod_curso = (dr[1] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Nome = dr.GetString(2).ToString(),
                            Dt_inclusao = dr.GetDateTime(3),
                            Dt_alteracao = dr.GetDateTime(4),
                        };
                        curso.Add(p);
                    }
                }
            }

            return curso;
        }

    }
}
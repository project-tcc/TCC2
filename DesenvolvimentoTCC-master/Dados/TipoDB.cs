using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Dados
{
    public class TipoDB
    {
        private static SQLiteConnection sqliteConnection;

        public TipoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }


        public bool Salvar(Tipo tipo)
        {
            try
            {
                string sql = "INSERT INTO tipo_tb " + "(id, nome, dt_inclusao, dt_alteracao)" +
                      "values  (@Id, @nome, @dt_inclusao, @dt_alteracao)";


                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", tipo.Id);
                    cmd.Parameters.AddWithValue("@Nome", tipo.Nome);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", tipo.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", tipo.Dt_alteracao);

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
            sb.Append(" nome,");
            sb.Append(" dt_inclusao,");
            sb.Append(" dt_alteracao");
            sb.Append("FROM tipo_tb");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dat);
            }
            return dat;
        }


        public List<Tipo> ConsultarList()
        {
            SQLiteDataReader dr = null;
            List<Tipo> tipo = new List<Tipo>();

            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT id, ");
            sb.Append("        nome, ");
            sb.Append("        dt_inclusao,");
            sb.Append("        dt_alteracao");
            sb.Append("  FROM  tipo_tb ");

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
                        Tipo p = new Tipo()
                        {
                            Id = (dr[0] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Nome = dr.GetString(1).ToString(),
                            Dt_inclusao = dr.GetDateTime(2),
                            Dt_alteracao = dr.GetDateTime(3),
                        };
                        tipo.Add(p);
                    }
                }
            }

            return tipo;
        }
    }
}

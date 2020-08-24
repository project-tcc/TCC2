using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;

using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Dados
{
    public class PaisDB
    {
        private static SQLiteConnection sqliteConnection;

        public PaisDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Pais pais)
        {
            try
            {
                string sql = "INSERT INTO pais_tb " + "(Id, Nome, Dt_inclusao, Dt_alteracao)" + "values(@Id, @Nome, @Dt_inclusao, @Dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", pais.Id);
                    cmd.Parameters.AddWithValue("@Nome", pais.Nome);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", pais.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", pais.Dt_alteracao);

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
            sb.Append("FROM pais_tb");


            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dat);
            }
            return dat;

        }

        public List<Pais> ConsultarList()
        {
            SQLiteDataReader dr = null;
            List<Pais> pais = new List<Pais>();

            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT id, ");
            sb.Append("        nome, ");
            sb.Append("        dt_inclusao,");
            sb.Append("        dt_alteracao");
            sb.Append("  FROM  pais_tb ");

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
                        Pais p = new Pais()
                        {
                            Id = (dr[0] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Nome = dr.GetString(1).ToString(),
                            Dt_inclusao = dr.GetDateTime(2),
                            Dt_alteracao = dr.GetDateTime(3),
                        };
                        pais.Add(p);
                    }
                }
            }

            return pais;
        }
    }
}


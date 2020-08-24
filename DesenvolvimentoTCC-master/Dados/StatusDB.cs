using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class StatusDB
    {
        private static SQLiteConnection sqliteConnection;
        public StatusDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Status status)
        {
            try
            {
                string sql = "INSERT INTO status_tb " + "(id, nome ,data_inclusao, data_alteracao)" +
                    "values  (@Id, @Nome, @Data_inclusao, @Data_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", status.Id);
                    cmd.Parameters.AddWithValue("@nome", status.Nome);
                    cmd.Parameters.AddWithValue("@data_inclusao", status.Data_inclusao);
                    cmd.Parameters.AddWithValue("@data_alteracao", status.Data_alteracao);

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
            sb.Append(" data_inclusao,");
            sb.Append(" data_alteracao");
            sb.Append("FROM status_tb");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dat);
            }
            return dat;
        }

        public List<Status> ConsultarList()
        {
            SQLiteDataReader dr = null;
            List<Status> status = new List<Status>();

            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT id, ");
            sb.Append("        nome, ");
            sb.Append("        data_inclusao,");
            sb.Append("        data_alteracao");
            sb.Append("  FROM  status_tb ");

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
                        Status p = new Status()
                        {
                            Id = (dr[0] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Nome = dr.GetString(1).ToString(),
                            Data_inclusao = dr.GetDateTime(2),
                            Data_alteracao = dr.GetDateTime(3),
                        };
                        status.Add(p);
                    }
                }
            }

            return status;
        }

    }
}

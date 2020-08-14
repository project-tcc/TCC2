using Model;
using System;
using System.Collections.Generic;
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
                    "values  (@Id, @nome, @data_inclusao, @data_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", status.id);
                    cmd.Parameters.AddWithValue("@nome", status.nome);
                    cmd.Parameters.AddWithValue("@data_inclusao", status.data_inclusao);
                    cmd.Parameters.AddWithValue("@data_alteracao", status.data_alteracao);

                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}

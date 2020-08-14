using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Data.SQLite;

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
                    cmd.Parameters.AddWithValue("@id", tipo.id);
                    cmd.Parameters.AddWithValue("@nome", tipo.nome);
                    cmd.Parameters.AddWithValue("@dt_inclusao", tipo.dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_alteracao", tipo.dt_alteracao);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }



        }

    }
}

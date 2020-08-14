using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Dados
{
    public class SexoDB
    {
        private static SQLiteConnection sqliteConnection;

        public SexoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Sexo sexo)
        {
            try
            {
              string sql = "INSERT INTO sexo_tb " + "(id, nome, dt_inclusao, dt_alteracao)" +
                    "values  (@Id, @nome, @dt_inclusao, @dt_alteracao)";


                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", sexo.id);
                    cmd.Parameters.AddWithValue("@nome", sexo.nome);
                    cmd.Parameters.AddWithValue("@dt_inclusao", sexo.dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_alteracao", sexo.dt_alteracao);

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

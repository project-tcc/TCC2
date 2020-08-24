using System;
using System.Collections.Generic;
using Model;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class TelaDB
    {
        private static SQLiteConnection sqliteConnection;

        public TelaDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Tela Tela)
        {
            try
            {
                string sql = "INSERT INTO tela_tb " + "(id, nome , descricao, dt_inclusao, dt_alteracao)" +
                    "values  (@Id, @Nome, @Descricao @Dt_inclusao, @Dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", Tela.Id);
                    cmd.Parameters.AddWithValue("@Nome", Tela.Nome);
                    cmd.Parameters.AddWithValue("@Descricao", Tela.Descricao);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", Tela.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", Tela.Dt_alteracao);

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

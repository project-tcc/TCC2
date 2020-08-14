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
                    "values  (@Id, @nome, @descricao @dt_inclusao, @dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", Tela.id);
                    cmd.Parameters.AddWithValue("@nome", Tela.nome);
                    cmd.Parameters.AddWithValue("@descricao", Tela.nome);
                    cmd.Parameters.AddWithValue("@dt_inclusao", Tela.dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_inclusao", Tela.dt_alteracao);

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

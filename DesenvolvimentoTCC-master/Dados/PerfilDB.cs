using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PerfilDB
    {
        private static SQLiteConnection sqliteConnection;

        public PerfilDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Perfil perfil)
        {
            try 
            {
                string sql = "INSERT INTO perfil_tb " + "(id, usuario_id, tipo_id, tela_id, consultar, atualizar, deletar, imprimir, dt_inclusao, dt_alteracao)" +
                    "values  (@Id, @Usuario_id, @Tipo_id, @Tela_id, @Consultar, @Atualizar, @Deletar, @Imprimir, @Dt_inclusao, @Dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", perfil.Id);
                    cmd.Parameters.AddWithValue("@Usuario_id", perfil.Usuario_id);
                    cmd.Parameters.AddWithValue("@Tipo_id", perfil.Tipo_id);
                    cmd.Parameters.AddWithValue("@Tela_id", perfil.Tela_id);
                    cmd.Parameters.AddWithValue("@Consultar", perfil.Consultar);
                    cmd.Parameters.AddWithValue("@Atualizar", perfil.Atualizar);
                    cmd.Parameters.AddWithValue("@Deletar", perfil.Deletar);
                    cmd.Parameters.AddWithValue("@Imprimir", perfil.Imprimir);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", perfil.Id);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", perfil.Data_alteracao);

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

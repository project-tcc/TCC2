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
                    "values  (@Id, @usuario_id, @tipo_id, @tela_id, @consultar, @atualizar, @deletar, @imprimir, @dt_inclusao, @dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", perfil.id);
                    cmd.Parameters.AddWithValue("@usuario_id", perfil.usuario_id);
                    cmd.Parameters.AddWithValue("@tipo_id", perfil.tipo_id);
                    cmd.Parameters.AddWithValue("@tela_id", perfil.tela_id);
                    cmd.Parameters.AddWithValue("@consultar", perfil.consultar);
                    cmd.Parameters.AddWithValue("@atualizar", perfil.atualizar);
                    cmd.Parameters.AddWithValue("@deletar", perfil.deletar);
                    cmd.Parameters.AddWithValue("@imprimir", perfil.imprimir);
                    cmd.Parameters.AddWithValue("@dt_inclusao", perfil.id);
                    cmd.Parameters.AddWithValue("@dt_alteracao", perfil.data_alteracao);

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

using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Dados
{
    public class FuncionarioDB
    {

        private static SQLiteConnection sqliteConnection;

        public FuncionarioDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }


        public bool Salvar(Funcionario funcionario)
        {

            try
            {
                string sql = "INSERT INTO funcionario_tb" + "(id, nome_completo, rg, cpf, telefone_fixo, telefone_celular, telefone_emergencial, end_cep, end_complemento, end_bairro, end_cidade, tipo_logradouro, end_rua, numresidencia, data_cadastro, data_nascimento, nacionalidade_id, sexo_id, status_id, tipo_id, dt_inclusao, dt_alteracao)"
                + "values(@id, @nome_completo, @rg, @cpf, @telefone_fixo, @telefone_celular, @telefone_emergencial, @end_cep, @end_complemento, @end_bairro, @end_cidade, @tipo_logradouro, @end_rua, @numresidencia, @data_cadastro, @data_nascimento, @nacionalidade_id, @sexo_id, @status_id, @tipo_id, @dt_inclusao, @dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", funcionario.id);
                    cmd.Parameters.AddWithValue("@nome_completo", funcionario.nome_completo);
                    cmd.Parameters.AddWithValue("@rg", funcionario.rg);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                    cmd.Parameters.AddWithValue("@telefone_fixo", funcionario.telefone_fixo);
                    cmd.Parameters.AddWithValue("@telefone_celular", funcionario.telefone_celular);
                    cmd.Parameters.AddWithValue("@telefone_emergencial", funcionario.telefone_emergencial);
                    cmd.Parameters.AddWithValue("@end_cep", funcionario.end_cep);
                    cmd.Parameters.AddWithValue("@end_complemento", funcionario.end_complemento);
                    cmd.Parameters.AddWithValue("@end_bairro", funcionario.end_bairro);
                    cmd.Parameters.AddWithValue("@end_cidade", funcionario.end_cidade);
                    cmd.Parameters.AddWithValue("@tipo_logradouro", funcionario.tipo_logradouro);
                    cmd.Parameters.AddWithValue("@end_rua", funcionario.end_rua);
                    cmd.Parameters.AddWithValue("@numresidencia", funcionario.numresidencia);
                    cmd.Parameters.AddWithValue("@data_cadastro", funcionario.data_cadastro);
                    cmd.Parameters.AddWithValue("@data_nascimento", funcionario.data_nascimento);
                    cmd.Parameters.AddWithValue("@nacionalidade_id", funcionario.nacionalidade_id);
                    cmd.Parameters.AddWithValue("@sexo_id", funcionario.sexo_id);
                    cmd.Parameters.AddWithValue("@status_id", funcionario.status_id);
                    cmd.Parameters.AddWithValue("@tipo_id", funcionario.tipo_id);
                    cmd.Parameters.AddWithValue("@dt_inclusao", funcionario.dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_alteracao", funcionario.data_alteracao);

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

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
                string sql = "INSERT INTO funcionario_tb" + "(nome_completo, rg, cpf, telefone_fixo, telefone_celular, telefone_emergencial, " +
                    "end_cep, end_complemento, end_bairro, end_cidade, tipo_logradouro, end_rua, numresidencia, data_nascimento, " +
                    "nacionalidade_id, sexo_id, status_id, tipo_id, dt_inclusao, dt_alteracao)"



                + "values(@Nome_completo, @Rg, @Cpf, @Telefone_fixo, @Telefone_celular, @Telefone_emergencial, @End_cep, @End_complemento, @End_bairro, @End_cidade, @Tipo_logradouro, @End_rua, @Numresidencia, @Data_nascimento, @Nacionalidade_id, @Sexo_id, @Status_id, @Tipo_id, @Dt_inclusao, @Dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", funcionario.Id);
                    cmd.Parameters.AddWithValue("@Nome_completo", funcionario.Nome_completo);
                    cmd.Parameters.AddWithValue("@Rg", funcionario.Rg);
                    cmd.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                    cmd.Parameters.AddWithValue("@Telefone_fixo", funcionario.Telefone_fixo);
                    cmd.Parameters.AddWithValue("@Telefone_celular", funcionario.Telefone_celular);
                    cmd.Parameters.AddWithValue("@Telefone_emergencial", funcionario.Telefone_emergencial);
                    cmd.Parameters.AddWithValue("@End_cep", funcionario.End_cep);
                    cmd.Parameters.AddWithValue("@End_complemento", funcionario.End_complemento);
                    cmd.Parameters.AddWithValue("@End_bairro", funcionario.End_bairro);
                    cmd.Parameters.AddWithValue("@End_cidade", funcionario.End_cidade);
                    cmd.Parameters.AddWithValue("@Tipo_logradouro", funcionario.Tipo_logradouro);
                    cmd.Parameters.AddWithValue("@End_rua", funcionario.End_rua);
                    cmd.Parameters.AddWithValue("@Numresidencia", funcionario.Numresidencia);
                    //cmd.Parameters.AddWithValue("@Data_cadastro", funcionario.Data_cadastro);
                    cmd.Parameters.AddWithValue("@Data_nascimento", funcionario.Data_nascimento);
                    cmd.Parameters.AddWithValue("@Nacionalidade_id", funcionario.Nacionalidade_id);
                    cmd.Parameters.AddWithValue("@Sexo_id", funcionario.Sexo_id);
                    cmd.Parameters.AddWithValue("@Status_id", funcionario.Status_id);
                    cmd.Parameters.AddWithValue("@Tipo_id", funcionario.Tipo_id);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", funcionario.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", funcionario.Dt_alteracao);

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

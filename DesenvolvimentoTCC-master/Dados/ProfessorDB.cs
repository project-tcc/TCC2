using Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProfessorDB
    {
        private static SQLiteConnection sqliteConnection;

        public ProfessorDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Professor professor)
        {
            try
            {
                string sql = "INSERT INTO professor_tb" + "(nome_completo, rg, cpf, telefone_fixo, telefone_celular, telefone_emergencial, " +
                    "end_cep, end_complemento, end_bairro, end_cidade, tipo_logradouro, end_rua, numresidencia, formacao, codigo_acesso, " +
                    "senha_acesso, status_id, nacionalidade_id, sexo_id, tipo_id, dt_inclusao, dt_alteracao, dt_admissao)" +
                 
                  "values(@Nome_completo, @Rg, @Cpf, @Telefone_fixo, @Telefone_celular, @Telefone_emergencial, " +
                 "@End_cep, @End_complemento, @End_bairro, @End_cidade, @Tipo_logradouro, @End_rua, @Numresidencia, @Formacao, " +
                 "@Codigo_acesso, @Senha_acesso,  @Status_id, @Nacionalidade_id, @Sexo_id, @Tipo_id, @Dt_inclusao, @Dt_alteracao, @Dt_Admissao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", professor.Id);
                    cmd.Parameters.AddWithValue("@Nome_completo", professor.Nome_completo);
                    cmd.Parameters.AddWithValue("@Rg", professor.Rg);
                    cmd.Parameters.AddWithValue("@Cpf", professor.Cpf);
                    cmd.Parameters.AddWithValue("@Telefone_fixo", professor.Telefone_fixo);
                    cmd.Parameters.AddWithValue("@Telefone_celular", professor.Telefone_celular);
                    cmd.Parameters.AddWithValue("@Telefone_emergencial", professor.Telefone_emergencial);
                    cmd.Parameters.AddWithValue("@End_cep", professor.End_cep);
                    cmd.Parameters.AddWithValue("@End_complemento", professor.End_complemento);
                    cmd.Parameters.AddWithValue("@End_bairro", professor.End_bairro);
                    cmd.Parameters.AddWithValue("@End_cidade", professor.End_cidade);
                    cmd.Parameters.AddWithValue("@Tipo_logradouro", professor.Tipo_logradouro);
                    cmd.Parameters.AddWithValue("@End_rua", professor.End_rua);
                    cmd.Parameters.AddWithValue("@Numresidencia", professor.Numresidencia);
                    cmd.Parameters.AddWithValue("@Formacao", professor.Formacao);
                    cmd.Parameters.AddWithValue("@Codigo_acesso", professor.Codigo_acesso);
                    cmd.Parameters.AddWithValue("@Senha_acesso", professor.Senha_acesso);
                    cmd.Parameters.AddWithValue("@Status_id", professor.Status_id);
                    cmd.Parameters.AddWithValue("@Nacionalidade_id", professor.Nacionalidade_id);
                    cmd.Parameters.AddWithValue("@Sexo_id", professor.Sexo_id); 
                    cmd.Parameters.AddWithValue("@Tipo_id", professor.Tipo_id);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", professor.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Dt_alteracao", professor.Dt_alteracao);
                    cmd.Parameters.AddWithValue("@Dt_admissao", professor.Dt_admissao);

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


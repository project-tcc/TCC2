using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{

    public class AlunoDB
    {
        private static SQLiteConnection sqliteConnection;
        public AlunoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }


        public bool Salvar(Aluno aluno)

        {
            try
            {
                string sql = "INSERT INTO aluno_tb " + "" +
                    "(ra, curso, data_de_ingresso, " +
                    "Nome_completo, rg, cpf, telefone_fixo, " +
                    "telefone_celular, nacionalidade, nome_pai, " +
                    "nome_mae, end_cep, end_complemento, end_bairro, " +
                    "end_cidade, tipo_logradouro, end_rua, " +
                    "telefone_emergencial, data_nascimento, email, sexo_id, " +
                    "status_id, tipo_id, dt_inclusao, data_alteracao)" + ""

                    + "values (@Ra, @Curso, @Data_de_ingresso, " +
                    "@Nome_completo, @Rg, @cpf, @telefone_fixo, @Telefone_celular, " +
                    "@Nacionalidade, @Nome_pai, @Nome_mae, @End_cep, @End_complemento, " +
                    "@End_bairro, @End_cidade, @Tipo_logradouro, @End_rua, @Telefone_emergencial, " +
                    "@Data_nascimento, @Email, @Sexo_id, @Status_id, @Tipo_id, @Dt_inclusao, @Data_alteracao)";


                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Id", aluno.Id);
                    cmd.Parameters.AddWithValue("@Ra", aluno.Ra);
                    cmd.Parameters.AddWithValue("@End_cidade", aluno.End_cidade);
                    cmd.Parameters.AddWithValue("@End_cep", aluno.End_cep);
                    cmd.Parameters.AddWithValue("@End_rua", aluno.End_rua);
                    cmd.Parameters.AddWithValue("@End_complemento", aluno.End_complemento);
                    cmd.Parameters.AddWithValue("@End_bairro", aluno.End_bairro);
                    cmd.Parameters.AddWithValue("@Tipo_logradouro", aluno.Tipo_logradouro);
                    cmd.Parameters.AddWithValue("@Telefone_fixo", aluno.Telefone_fixo);
                    cmd.Parameters.AddWithValue("@Telefone_celular", aluno.Telefone_celular);
                    cmd.Parameters.AddWithValue("@Telefone_emergencial", aluno.Telefone_emergencial);
                    cmd.Parameters.AddWithValue("@Curso", aluno.Curso);
                    cmd.Parameters.AddWithValue("@Data_de_ingresso", aluno.Data_de_ingresso);
                    cmd.Parameters.AddWithValue("@Nome_pai", aluno.Nome_pai);
                    cmd.Parameters.AddWithValue("@Nome_mae", aluno.Nome_mae);
                    cmd.Parameters.AddWithValue("@Rg", aluno.Rg);
                    cmd.Parameters.AddWithValue("@Cpf", aluno.Cpf);
                    cmd.Parameters.AddWithValue("@Email", aluno.Email);
                    cmd.Parameters.AddWithValue("@Nacionalidade", aluno.Nacionalidade);
                    cmd.Parameters.AddWithValue("@Status_id", aluno.Status_id);
                    cmd.Parameters.AddWithValue("@Sexo_id", aluno.Sexo_id);
                    cmd.Parameters.AddWithValue("@Tipo_id", aluno.Tipo_id);
                    cmd.Parameters.AddWithValue("@Dt_inclusao", aluno.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@Data_alteracao", aluno.Data_alteracao);
                    cmd.Parameters.AddWithValue("@Data_nascimento", aluno.Data_nascimento);
                    cmd.Parameters.AddWithValue("@Nome_completo", aluno.Nome_completo);


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

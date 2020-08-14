using Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{

    public class AlunoDB
    {
        //Conexão com banco
        private static SQLiteConnection sqliteConnection;

        public AlunoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }


        public bool Salvar(Aluno aluno)

        {
            try
            {
                string sql = "INSERT INTO aluno_tb " +"(id, ra, curso, data_de_ingresso, nome_completo, rg, cpf, telefone_fixo, " +
                    "telefone_celular, nacionalidade, nome_pai, nome_mae, end_cep,"+" end_complemento, end_bairro, end_cidade, tipo_logradouro, end_rua, telefone_emergencial, data_nascimento, email, sexo_id, " +
                    "status_id, tipo_id, dt_inclusao, data_alteracao)" +"" +"values (@Id, @ra, @curso, @data_de_ingresso, @nome_completo, @rg, @cpf, @telefone_fixo, @telefone_celular, @nacionalidade, @nome_pai, @nome_mae, @end_cep, @end_complemento, @end_bairro, @end_cidade, @tipo_logradouro, @end_rua, @telefone_emergencial, @data_nascimento, @email, @sexo_id, @status_id, @tipo_id, @dt_inclusao, @data_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", aluno.id);
                    cmd.Parameters.AddWithValue("@ra", aluno.ra);
                    cmd.Parameters.AddWithValue("@curso", aluno.curso);
                    cmd.Parameters.AddWithValue("@data_de_ingresso", aluno.data_de_ingresso);
                    cmd.Parameters.AddWithValue("@nome_completo", aluno.nome_completo);
                    cmd.Parameters.AddWithValue("@rg", aluno.rg);
                    cmd.Parameters.AddWithValue("@cpf", aluno.cpf);
                    cmd.Parameters.AddWithValue("@telefone_fixo", aluno.telefone_fixo);
                    cmd.Parameters.AddWithValue("@telefone_celular", aluno.telefone_celular);
                    cmd.Parameters.AddWithValue("@nacionalidade", aluno.nacionalidade);
                    cmd.Parameters.AddWithValue("@nome_pai", aluno.nome_pai);
                    cmd.Parameters.AddWithValue("@nome_mae", aluno.nome_mae);
                    cmd.Parameters.AddWithValue("@end_cep", aluno.end_cep);
                    cmd.Parameters.AddWithValue("@end_complemento", aluno.end_complemento);
                    cmd.Parameters.AddWithValue("@end_bairro", aluno.end_bairro);
                    cmd.Parameters.AddWithValue("@end_cidade", aluno.end_cidade);
                    cmd.Parameters.AddWithValue("@tipo_logradouro", aluno.tipo_logradouro);
                    cmd.Parameters.AddWithValue("@end_rua", aluno.end_rua);
                    cmd.Parameters.AddWithValue("@telefone_emergencial", aluno.telefone_emergencial);
                    cmd.Parameters.AddWithValue("@data_nascimento", aluno.data_nascimento);
                    cmd.Parameters.AddWithValue("@email", aluno.email);
                    cmd.Parameters.AddWithValue("@sexo_id", aluno.sexo_id);
                    cmd.Parameters.AddWithValue("@tipo_id", aluno.tipo_id);
                    cmd.Parameters.AddWithValue("@dt_inclusao", aluno.dt_inclusao);
                    cmd.Parameters.AddWithValue("@data_alteracao", aluno.data_alteracao);

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

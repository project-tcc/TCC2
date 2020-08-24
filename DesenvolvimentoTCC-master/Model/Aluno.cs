using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Ra { get; set; }
        public string End_cidade { get; set; }
        public string End_cep { get; set; }
        public string End_rua { get; set; }
        public string End_complemento { get; set; }
        public string End_bairro { get; set; }
        public string Tipo_logradouro { get; set; }
        public string Telefone_fixo { get; set; }
        public string Telefone_celular { get; set; }
        public string Telefone_emergencial { get; set; }
        public string Curso { get; set; }
        public DateTime Data_de_ingresso { get; set; }
        public string Nome_pai { get; set; }
        public string Nome_mae { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Status_id { get; set; }
        public string Sexo_id { get; set; }
        public string Tipo_id { get; set; }
        public DateTime Dt_inclusao { get; set; }
        public DateTime Data_alteracao { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string Nome_completo { get; set; }

       
    }
}

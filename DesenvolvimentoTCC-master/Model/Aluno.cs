using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aluno
    {
        public int id { get; set; }
        public int ra { get; set; }
        public string end_cidade { get; set; }
        public string end_cep { get; set; }
        public string end_rua { get; set; }
        public string end_complemento { get; set; }
        public string end_bairro { get; set; }
        public string tipo_logradouro { get; set; }
        public string telefone_fixo { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_emergencial { get; set; }
        public string curso { get; set; }
        public DateTime data_de_ingresso { get; set; }
        public string nome_pai { get; set; }
        public string nome_mae { get; set; }
        public int rg { get; set; }
        public int cpf { get; set; }
        public string email { get; set; }
        public int nacionalidade { get; set; }
        public int status_id { get; set; }
        public int sexo_id { get; set; }
        public int tipo_id { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime data_alteracao { get; set; }
        public DateTime data_nascimento { get; set; }
        public string nome_completo { get; set; }

        public override string ToString()
        {
            return this.nome_completo;
        }
    }
}

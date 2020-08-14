using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        public int id { get; set; }
        public string nome_completo { get; set; }
        public int rg { get; set; }
        public int cpf { get; set; }
        public string telefone_fixo { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_emergencial { get; set; }
        public string end_cep { get; set; }
        public string end_complemento { get; set; }
        public string end_bairro { get; set; }
        public string end_cidade { get; set; }
        public string tipo_logradouro { get; set; }
        public string end_rua { get; set; }
        public int numresidencia { get; set; }
        public string formacao { get; set; }
        public string codigo_acesso { get; set; }
        public int senha_acesso { get; set; }
        public int nacionalidade_id { get; set; }
        public int status_id { get; set; }
        public int sexo_id { get; set; }
        public int tipo_id { get; set; }
        public string dt_inclusao { get; set; }
        public string data_alteracao { get; set; }
        public DateTime data_cadastro { get; set; }

    }
}

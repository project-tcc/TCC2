using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome_completo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone_fixo { get; set; }
        public string Telefone_celular { get; set; }
        public string Telefone_emergencial { get; set; }
        public string End_cep { get; set; }
        public string End_complemento { get; set; }
        public string End_bairro { get; set; }
        public string End_cidade { get; set; }
        public string Tipo_logradouro { get; set; }
        public string End_rua { get; set; }
        public string Numresidencia { get; set; }
        public string Formacao { get; set; }
        public string Codigo_acesso { get; set; }
        public int Senha_acesso { get; set; }
        public string Nacionalidade_id { get; set; }
        public string Status_id { get; set; }
        public string Sexo_id { get; set; }
        public string Tipo_id { get; set; }
        public DateTime Dt_inclusao { get; set; }
        public DateTime Dt_alteracao { get; set; }
        public DateTime Dt_admissao { get; set; }

    }
}

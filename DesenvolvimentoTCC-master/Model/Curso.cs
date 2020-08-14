using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Curso
    {
        public int id { get; set; }
        public int cod_curso { get; set; }
        public string nome { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime data_alteracao { get; set; }

        public override string ToString()
        {
            return this.nome;
        }
    }
}

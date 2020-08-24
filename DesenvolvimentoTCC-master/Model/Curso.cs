using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Curso
    {
        public int Id { get; set; }
        public int Cod_curso { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_inclusao { get; set; }
        public DateTime Dt_alteracao { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Perfil
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public int tipo_id { get; set; }
        public int tela_id { get; set; }
        public int consultar { get; set; }
        public int atualizar { get; set; }
        public int deletar { get; set; }
        public int imprimir { get; set; }
        public DateTime dt_inclusao { get; set; }
        public DateTime data_alteracao { get; set; }

        


    }
}

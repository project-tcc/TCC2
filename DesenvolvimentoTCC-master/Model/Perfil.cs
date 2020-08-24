using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Perfil
    {
        public int Id { get; set; }
        public int Usuario_id { get; set; }
        public int Tipo_id { get; set; }
        public int Tela_id { get; set; }
        public int Consultar { get; set; }
        public int Atualizar { get; set; }
        public int Deletar { get; set; }
        public int Imprimir { get; set; }
        public DateTime Dt_inclusao { get; set; }
        public DateTime Data_alteracao { get; set; }



        //public override string ToString()
        //{
        //    return this.tipo_id; //irmao aqui ta retornando int e tem que ser string, 
        //}
    }
}

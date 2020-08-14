using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Model;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class CursoDB
    {
        private static SQLiteConnection sqliteConnection;
        public CursoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        //public bool Salvar(Curso curso)
        //{ 
        
        
        //}
    }
}

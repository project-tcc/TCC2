﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ConnectionSQLite
    {

        private static SQLiteConnection sqliteConnection;
        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection(@"Data Source =  C:\tmp\banco_tcc.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }



    }
}

using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Documents;

namespace Dados
{
    public class PaisDB
    {
        private static SQLiteConnection sqliteConnection;

        public PaisDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Pais pais)
        {

            try
            {
                string sql = "INSERT INTO pais_tb " + "(id, nome, dt_inclusao, dt_alteracao)" + "values(@id, @nome, @dt_inclusao, @dt_alteracao)";

                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", pais.id);
                    cmd.Parameters.AddWithValue("@nome", pais.nome) ;
                    cmd.Parameters.AddWithValue("@dt_inclusao", pais.dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_alteracao", pais.dt_alteracao);

                    cmd.ExecuteNonQuery();

                }
                return true;



            }
            catch (Exception)
            {

                throw;
            }
        }

        //public List ConsultarTudo()
        //{
        //    List dat = new List();
        //    SQLiteDataAdapter da = null;

        //    StringBuilder sb = new StringBuilder();

        //    sb.Append(" select pais_tb.nome, ");       

        //    sb.Append("from pais_tb inner join = pais_tb.nome    ");


        //    using (var cmd = sqliteConnection.CreateCommand())
        //    {
        //        cmd.CommandText = sb.ToString();
        //        da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
               
        //    }
        //    return dat;


        //}


        }
}

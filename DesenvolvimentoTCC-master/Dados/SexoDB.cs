﻿using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Dados
{
    public class SexoDB
    {
        private static SQLiteConnection sqliteConnection;

        public SexoDB()
        {
            sqliteConnection = ConnectionSQLite.DbConnection();
        }

        public bool Salvar(Sexo sexo)
        {
            try
            {
                string sql = "INSERT INTO sexo_tb " + "(id, nome, dt_inclusao, dt_alteracao)" +
                      "values  (@Id, @nome, @dt_inclusao, @dt_alteracao)";


                using (var cmd = sqliteConnection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", sexo.Id);
                    cmd.Parameters.AddWithValue("@nome", sexo.Nome);
                    cmd.Parameters.AddWithValue("@dt_inclusao", sexo.Dt_inclusao);
                    cmd.Parameters.AddWithValue("@dt_alteracao", sexo.Dt_alteracao);

                    cmd.ExecuteNonQuery();

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable ConsultarTudo()
        {
            DataTable dat = new DataTable();
            SQLiteDataAdapter da = null;

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT id,");
            sb.Append(" nome,");
            sb.Append(" dt_inclusao,");
            sb.Append(" dt_alteracao");
            sb.Append("FROM sexo_tb");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                da = new SQLiteDataAdapter(cmd.CommandText, sqliteConnection);
                da.Fill(dat);
            }
            return dat;
        }

        public List<Sexo> ConsultarList()
        {
            SQLiteDataReader dr = null;
            List<Sexo> sexo = new List<Sexo>();

            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT id, ");
            sb.Append("        nome, ");
            sb.Append("        dt_inclusao,");
            sb.Append("        dt_alteracao");
            sb.Append("  FROM  sexo_tb ");

            using (var cmd = sqliteConnection.CreateCommand())
            {
                cmd.CommandText = sb.ToString();
                dr = cmd.ExecuteReader();
            }

            if (dr.HasRows)
            {
                {
                    while (dr.Read())
                    {
                        Sexo p = new Sexo()
                        {
                            Id = (dr[0] == DBNull.Value) ? 0 : int.Parse(dr[0].ToString()),
                            Nome = dr.GetString(1).ToString(),
                            Dt_inclusao = dr.GetDateTime(2),
                            Dt_alteracao = dr.GetDateTime(3),
                        };
                        sexo.Add(p);
                    }
                }
            }

            return sexo;
        }
    }
}

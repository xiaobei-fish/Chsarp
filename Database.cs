using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Database
    {
        static String connetStr = "datasource=localhost;port=3306;username=root;password=qwe123;database=csharp;";
        public MySqlConnection conn;
        public MySqlDataReader dataReader;
        public MySqlDataAdapter adp;
        public DataSet ds;
        static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        private Database()
        {
            conn = new MySqlConnection(connetStr);
        }
        ~Database()
        {
            conn.Close();
        }
        public void Select(string sql, System.Windows.Forms.DataGridView dataGridView)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            adp = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            dataGridView.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
        public bool SelectExist(string sql)
        {
            return Select(sql).Tables[0].Rows.Count > 0;
        }
        public DataSet Select(string sql)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            adp = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            conn.Close();
            return ds;
        }
        public void NonQuery(string sql)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}

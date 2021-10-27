using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class StdLogin : Form
    {
        public StdLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.BringToFront();
            home.Show();
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim(), password = textBox2.Text.Trim();
            if (username.Length != 0)
            {
                string sql = "select * from std_mes where std_account='" + username + "' and std_password='" + password + "'";
                DataRowCollection drc = Database.Instance.Select(sql).Tables[0].Rows;
                if(drc.Count > 0)
                {
                    var tmp = drc[0];
                    saveUser(tmp["id"].ToString(), tmp["std_account"].ToString(), tmp["std_password"].ToString());
                    StdMain stdMain = new StdMain();
                    stdMain.BringToFront();
                    stdMain.Show();
                    this.Hide();
                    return;
                }
                MessageBox.Show("用户名或者密码输入错误！");
            }
        }
        void saveUser(string id, string account, string pw)
        {
            User.Instance.id = id;
            User.Instance.account = account;
            User.Instance.password = pw;
        }
    }
}

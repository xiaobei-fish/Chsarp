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
    public partial class AdmLogin : Form
    {
        public AdmLogin()
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
                string sql = "select * from adm_mes where adm_account='" + username + "' and adm_password='" + password + "'";
                DataRowCollection drc = Database.Instance.Select(sql).Tables[0].Rows;
                if (drc.Count > 0)
                {
                    var tmp = drc[0];
                    saveUser(tmp["id"].ToString(), tmp["adm_account"].ToString(), tmp["adm_password"].ToString());
                    AdmMain adm = new AdmMain();
                    adm.BringToFront();
                    adm.Show();
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

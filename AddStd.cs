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
    public partial class AddStd : Form
    {
        public AddStd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(name.Text.Trim().Length == 0 || num.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息不能为空!");
                return;
            }
            string sql_check = "select * from std_mes where std_num='" + num.Text.Trim() + "'";
            if (Database.Instance.SelectExist(sql_check))
            {
                MessageBox.Show("学号重复，无法添加该学生!");
                return;
            }
            string sql_last = "select id from std_mes order by id desc";
            var flag = int.Parse( Database.Instance.Select(sql_last).Tables[0].Rows[0]["id"].ToString() ) + 1;
            string sex = radioButton1.Checked ? "男" : "女";
            string sql_insert = "insert into std_mes (std_num,std_account,std_password,std_sex,std_name,std_birthday)" +
                " values('" + num.Text.Trim() + "','std" + flag + "','std','" + sex + "','" + name.Text.Trim() + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
            Database.Instance.NonQuery(sql_insert);
            sql_insert = "insert into std_grade (std_num) values('" + num.Text.Trim() + "')";
            Database.Instance.NonQuery(sql_insert);
            MessageBox.Show("添加学生成功!");
            name.Text = ""; num.Text = ""; radioButton1.Checked = false; radioButton2.Checked = false;
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = (int)e.KeyChar;
            if (key >= 48 && key <= 57)
            {
                e.Handled = true;
            }
        }
    }
}

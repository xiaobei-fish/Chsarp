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
    public partial class DelStd : Form
    {
        public DelStd()
        {
            InitializeComponent();
        }

        private void DelStd_Load(object sender, EventArgs e)
        {
            string sql = "select std_num as 学号,std_account as 账号,std_sex as 性别,std_name as 姓名,std_birthday as 生日 from std_mes";
            Database.Instance.Select(sql, dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入不能为空!");
                return;
            }
            string sql_check = "select id from std_mes where std_num='" + textBox1.Text.Trim() + "'";
            if (!Database.Instance.SelectExist(sql_check))
            {
                MessageBox.Show("输入学号不存在!");
                return;
            }
            string sql_delete = "delete from std_mes where std_num='" + textBox1.Text.Trim() + "'";
            Database.Instance.NonQuery(sql_delete);
            string sql_delete_grade = "delete from std_grade where std_num='" + textBox1.Text.Trim() + "'";
            Database.Instance.NonQuery(sql_delete_grade);
            MessageBox.Show("删除成功!");
            string sql = "select std_num as 学号,std_account as 账号,std_sex as 性别,std_name as 姓名,std_birthday as 生日 from std_mes"; ;
            Database.Instance.Select(sql, dataGridView1);
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

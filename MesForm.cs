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
    public partial class MesForm : Form
    {
        public MesForm()
        {
            InitializeComponent();
        }

        private void MesForm_Load(object sender, EventArgs e)
        {
            string sql = "select std_num as 学号,std_account as 账号,std_sex as 性别,std_name as 姓名,std_birthday as 生日,std_evaluation as 评价 from std_mes";
            Database.Instance.Select(sql, dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

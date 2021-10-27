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
    public partial class StdGrade : Form
    {
        public StdGrade()
        {
            InitializeComponent();
        }

        private void StdGrade_Load(object sender, EventArgs e)
        {
            string sql = "select std_num as 学号,std_cn as 中文,std_mh as 数学,std_en as 外语,grade_average as 平均分 from std_grade where id='" + User.Instance.id + "'";
            Database.Instance.Select(sql,dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

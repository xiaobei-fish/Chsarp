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
    public partial class AdmEvaluation : Form
    {
        public AdmEvaluation()
        {
            InitializeComponent();
        }

        private void AdmEvaluation_Load(object sender, EventArgs e)
        {
            string sql = "select std_evaluation from std_mes where id='" + User.Instance.id + "'";
            textBox1.Text = Database.Instance.Select(sql).Tables[0].Rows[0]["std_evaluation"].ToString();
        }
    }
}

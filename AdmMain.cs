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
    public partial class AdmMain : Form
    {
        public AdmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StdMes stm = new StdMes();
            stm.BringToFront();
            stm.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

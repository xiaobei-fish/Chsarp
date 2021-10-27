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
    public partial class StdMes : Form
    {
        public StdMes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStd add = new AddStd();
            add.BringToFront();
            add.Show();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelStd ded = new DelStd();
            ded.BringToFront();
            ded.Show();
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MesForm msf = new MesForm();
            msf.BringToFront();
            msf.Show();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            return;
        }
    }
}

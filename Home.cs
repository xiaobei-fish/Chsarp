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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StdLogin stdLogin = new StdLogin();
            stdLogin.BringToFront();
            stdLogin.Show();
            this.Hide();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdmLogin admLogin = new AdmLogin();
            admLogin.BringToFront();
            admLogin.Show();
            this.Hide();
            return;
        }

    
    }
}

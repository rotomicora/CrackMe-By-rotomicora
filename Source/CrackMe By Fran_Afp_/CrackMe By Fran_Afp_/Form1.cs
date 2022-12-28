using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackMe_By_Fran_Afp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "github.com/franafp")
            {

                status.Text = "Valid Password";
                MessageBox.Show("Mega Reverser Bruh | Valid Password", "CrackMe v1.0 by Fran_Afp_");
                Application.Exit();
            }
            else
            {
                status.Text = "Invalid Password";
                MessageBox.Show("Shitty Reverser Bro, STFU", "CrackMe v1.0 by Fran_Afp_",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}

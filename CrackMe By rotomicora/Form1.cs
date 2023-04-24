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

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            {

                if (siticoneTextBox1.Text == "N0xIuS0nT0p!")
                {

                    status.Text = "Valid Key";
                    MessageBox.Show("Crackeddddd !!!", "CrackMe v2.0 by rotomicora#0001");
                    Process.Start("https://projectnoxius.xyz/discord");
                    Application.Exit();
                }
                else
                {
                    status.Text = "Invalid Key";
                    MessageBox.Show("Invalid Key", "CrackMe v2.0 by rotomicora#0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

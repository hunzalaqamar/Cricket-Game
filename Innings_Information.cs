using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Q1
{
    public partial class Innings_Information : Form
    {
        string matchSum1;
        bool flag1;
        public Innings_Information(string matchSum, bool flag)
        {
            InitializeComponent();
            matchSum1 = matchSum;
            flag1 = flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag1 == true)
            {
                Environment.Exit(0);
            }
            else
            {
                this.Hide();

            }
        }

        private void Innings_Information_Load(object sender, EventArgs e)
        {
            rtb1_II.AppendText(matchSum1);
        }
    }
}

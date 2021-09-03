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
    public partial class cricketForm : Form
    {
        Team[] team = new Team[2];
        public cricketForm()
        {
            InitializeComponent();
            team[0] = new Team();
            team[1] = new Team();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn3_Team1_Click(object sender, EventArgs e)
        {
            btn4_Team2.Enabled = false;
            rtb1_CF.Enabled = true;
            rtb2_CF.Enabled = true;
            rtb3_CF.Enabled = true;
            rtb4_CF.Enabled = true;
            rtb5_CF.Enabled = true;
        }

        private void btn4_Team2_Click(object sender, EventArgs e)
        {
            btn3_Team1.Enabled = false;
            rtb1_CF.Enabled = true;
            rtb2_CF.Enabled = true;
            rtb3_CF.Enabled = true;
            rtb4_CF.Enabled = true;
            rtb5_CF.Enabled = true;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            if(btn3_Team1.Enabled == true)
            {
                if (rtb1_CF.Text.ToString() != "" && rtb2_CF.Text.ToString() != "" && rtb3_CF.Text.ToString() != "" && rtb4_CF.Text.ToString() != "" && rtb5_CF.Text.ToString() != "")
                {
                    team[0].TeamName = "Team Alpha";
                    team[0].Players[0].PlayerName = rtb1_CF.Text.ToString();
                    team[0].Players[1].PlayerName = rtb2_CF.Text.ToString();
                    team[0].Players[2].PlayerName = rtb3_CF.Text.ToString();
                    team[0].Players[3].PlayerName = rtb4_CF.Text.ToString();
                    team[0].Players[4].PlayerName = rtb5_CF.Text.ToString();
                    team[1].TeamName = "Team Beta";
                    team[1].Players[0].PlayerName = "Hammad";
                    team[1].Players[1].PlayerName = "Abdullah";
                    team[1].Players[2].PlayerName = "Asfand";
                    team[1].Players[3].PlayerName = "Aarif";
                    team[1].Players[4].PlayerName = "Shahid";

                    for (int i = 0; i < team.Length; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            team[i].Players[j].PlayerBattingSkills = rnd.Next(1, 100);
                            team[i].Players[j].PlayerBowlingSkills = rnd.Next(1, 100);
                            team[i].Players[j].PlayerFieldingSkills = rnd.Next(1, 100);
                        }

                    }
                    MessageBox.Show("You have Selected " + team[0].TeamName, "Information", MessageBoxButtons.OK);
                    this.Hide();
                    Cricket_Game CG = new Cricket_Game(team);
                    CG.Show();
                }
                else
                {
                    MessageBox.Show("Enter all Player Names and Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(btn4_Team2.Enabled == true)
            {
                if (rtb1_CF.Text.ToString() != "" && rtb2_CF.Text.ToString() != "" && rtb3_CF.Text.ToString() != "" && rtb4_CF.Text.ToString() != "" && rtb5_CF.Text.ToString() != "")
                {
                    team[0].TeamName = "Team Alpha";
                    team[0].Players[0].PlayerName = "Hammad";
                    team[0].Players[1].PlayerName = "Abdullah";
                    team[0].Players[2].PlayerName = "Asfand";
                    team[0].Players[3].PlayerName = "Aarif";
                    team[0].Players[4].PlayerName = "Shahid";
                    team[1].TeamName = "Team Beta";
                    team[1].Players[0].PlayerName = rtb1_CF.Text.ToString();
                    team[1].Players[1].PlayerName = rtb2_CF.Text.ToString();
                    team[1].Players[2].PlayerName = rtb3_CF.Text.ToString();
                    team[1].Players[3].PlayerName = rtb4_CF.Text.ToString();
                    team[1].Players[4].PlayerName = rtb5_CF.Text.ToString();

                    for (int i = 0; i < team.Length; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            team[i].Players[j].PlayerBattingSkills = rnd.Next(1, 100);
                            team[i].Players[j].PlayerBowlingSkills = rnd.Next(1, 100);
                            team[i].Players[j].PlayerFieldingSkills = rnd.Next(1, 100);
                        }

                    }
                    MessageBox.Show("You have Selected " + team[1].TeamName, "Information", MessageBoxButtons.OK);
                    this.Hide();
                    Cricket_Game CG = new Cricket_Game(team);
                    CG.Show();
                }
                else
                {
                    MessageBox.Show("Enter all Player Names and Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }
    }
}

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
    public partial class Cricket_Game : Form
    {
        private Team[] team1;
        static double _oversDone;
        static int _ballsDone;
        bool _teamOnePlayed;
        bool _teamTwoPlayed;
        static string _matchSummary, _playerSummary, _matchSummary1, _playerSummary1, _fullMatchSummary;
        public Cricket_Game(Team[] team)
        {
            InitializeComponent();
            team1 = team;
            _oversDone = 0;
            _ballsDone = 0;
            _teamOnePlayed = false;
            _teamTwoPlayed = false;
        }

        private void pb1_CG_Click(object sender, EventArgs e)
        {
            bool flag = false;
            rtb2_CG.ScrollToCaret();
            Random rnd = new Random();
            int score = rnd.Next(0, 7);
            if(score != 5)
            {
                rtb4_CG.Text = score.ToString();
            }
            else
            {
                rtb4_CG.Text = "Out";
            }

            if(_teamOnePlayed == false && _teamTwoPlayed == false)
            {
                rtb5_CG.Text = team1[0].TeamName + " is Batting";

                if (team1[0].Players[0].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[0].Players[0].PlayerScore += score;
                        team1[0].Players[0].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[0].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " +_oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[0].Players[0].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[0].Players[0].PlayerStatus = "Out";
                        team1[0].Players[0].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[0].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[0].Players[0].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[0].Players[1].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[0].Players[1].PlayerScore += score;
                        team1[0].Players[1].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[1].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[0].Players[1].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[0].Players[1].PlayerStatus = "Out";
                        team1[0].Players[1].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[1].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[0].Players[1].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[0].Players[2].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[0].Players[2].PlayerScore += score;
                        team1[0].Players[2].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[2].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[0].Players[2].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[0].Players[2].PlayerStatus = "Out";
                        team1[0].Players[2].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[2].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[0].Players[2].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[0].Players[3].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[0].Players[3].PlayerScore += score;
                        team1[0].Players[3].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[3].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[0].Players[3].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[0].Players[3].PlayerStatus = "Out";
                        team1[0].Players[3].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[3].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[0].Players[3].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[0].Players[4].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[0].Players[4].PlayerScore += score;
                        team1[0].Players[4].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[4].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[0].Players[4].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[0].Players[4].PlayerStatus = "Out";
                        team1[0].Players[4].PlayerMatchInfo += "\n" + ("Player " + team1[0].Players[4].PlayerName + " Got Out");                        rtb2_CG.Text = team1[0].Players[4].PlayerMatchInfo;
                        rtb2_CG.Text = team1[0].Players[4].PlayerMatchInfo;
                        _ballsDone++;
                        _oversDone = 0.0;
                        _ballsDone = 0;
                    }
                }
            }
            else if(_teamOnePlayed == true && _teamTwoPlayed == false)
            {
                rtb5_CG.Text = team1[1].TeamName + " is Batting";

                if (team1[1].Players[0].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[1].Players[0].PlayerScore += score;
                        team1[1].Players[0].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[0].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[1].Players[0].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[1].Players[0].PlayerStatus = "Out";
                        team1[1].Players[0].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[0].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[1].Players[0].PlayerMatchInfo;
                        _ballsDone++;

                    }
                }

                else if (team1[1].Players[1].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[1].Players[1].PlayerScore += score;
                        team1[1].Players[1].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[1].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[1].Players[1].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[1].Players[1].PlayerStatus = "Out";
                        team1[1].Players[1].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[1].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[1].Players[1].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[1].Players[2].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[1].Players[2].PlayerScore += score;
                        team1[1].Players[2].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[2].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[1].Players[2].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[1].Players[2].PlayerStatus = "Out";
                        team1[1].Players[2].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[2].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[1].Players[2].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[1].Players[3].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[1].Players[3].PlayerScore += score;
                        team1[1].Players[3].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[3].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[1].Players[3].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[1].Players[3].PlayerStatus = "Out";
                        team1[1].Players[3].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[3].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[1].Players[3].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }

                else if (team1[1].Players[4].PlayerStatus != "Out")
                {
                    if (score != 5)
                    {
                        if (_ballsDone < 6)
                        {
                            _ballsDone++;
                            _oversDone += 0.1;
                        }
                        else
                        {
                            _ballsDone = 0;
                            _oversDone = (int)_oversDone;
                            _oversDone++;
                        }
                        team1[1].Players[4].PlayerScore += score;
                        team1[1].Players[4].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[4].PlayerName + " Scored " + score.ToString() + " Runs on " + _ballsDone.ToString() + " Ball of the match" + " in " + _oversDone.ToString() + " Overs");
                        rtb2_CG.Text = team1[1].Players[4].PlayerMatchInfo;
                        Cricket_Game_Load(sender, e);
                    }
                    else
                    {
                        team1[1].Players[4].PlayerStatus = "Out";
                        team1[1].Players[4].PlayerMatchInfo += "\n" + ("Player " + team1[1].Players[4].PlayerName + " Got Out");
                        rtb2_CG.Text = team1[1].Players[4].PlayerMatchInfo;
                        _ballsDone++;
                    }
                }
            }

            if ((_teamOnePlayed == false) && (team1[0].Players[0].PlayerStatus == "Out" && team1[0].Players[1].PlayerStatus == "Out" && team1[0].Players[2].PlayerStatus == "Out" && team1[0].Players[3].PlayerStatus == "Out" && team1[0].Players[4].PlayerStatus == "Out"))
            {
                _teamOnePlayed = true;
                _matchSummary = team1[0].TeamName + " Scored " + (team1[0].Players[0].PlayerScore + team1[0].Players[1].PlayerScore + team1[0].Players[2].PlayerScore + team1[0].Players[3].PlayerScore + team1[0].Players[4].PlayerScore).ToString();
                _playerSummary = ("\n"+ team1[0].Players[0].PlayerMatchInfo + team1[0].Players[1].PlayerMatchInfo + team1[0].Players[2].PlayerMatchInfo + team1[0].Players[3].PlayerMatchInfo + team1[0].Players[4].PlayerMatchInfo);
                _matchSummary += _playerSummary;
                Innings_Information II = new Innings_Information(_matchSummary, flag);
                II.Show();
            }
            else if((_teamTwoPlayed == false) && (team1[1].Players[0].PlayerStatus == "Out" && team1[1].Players[1].PlayerStatus == "Out" && team1[1].Players[2].PlayerStatus == "Out" && team1[1].Players[3].PlayerStatus == "Out" && team1[1].Players[4].PlayerStatus == "Out"))
            {
                _teamTwoPlayed = true;
                _matchSummary1 = team1[1].TeamName + " Scored " + (team1[1].Players[0].PlayerScore + team1[1].Players[1].PlayerScore + team1[1].Players[2].PlayerScore + team1[1].Players[3].PlayerScore + team1[1].Players[4].PlayerScore).ToString();
                _playerSummary1 = ("\n" + team1[1].Players[0].PlayerMatchInfo + team1[1].Players[1].PlayerMatchInfo + team1[1].Players[2].PlayerMatchInfo + team1[1].Players[3].PlayerMatchInfo + team1[1].Players[4].PlayerMatchInfo);
                _matchSummary1 += _playerSummary1;
            }

            int _teamOneScore = (team1[0].Players[0].PlayerScore + team1[0].Players[1].PlayerScore + team1[0].Players[2].PlayerScore + team1[0].Players[3].PlayerScore + team1[0].Players[4].PlayerScore);
            int _teamTwoScore = (team1[1].Players[0].PlayerScore + team1[1].Players[1].PlayerScore + team1[1].Players[2].PlayerScore + team1[1].Players[3].PlayerScore + team1[1].Players[4].PlayerScore);


            if ((_teamOnePlayed == true && _teamTwoPlayed == true))
            {
                _fullMatchSummary = "\n\n" + "Full Match Summary" + "\n\n" + _matchSummary + "\n\n" + _matchSummary1;
                flag = true;
                Innings_Information II = new Innings_Information(_fullMatchSummary, flag);
                II.Show();

                if(_teamOneScore > _teamTwoScore)
                {
                    MessageBox.Show("Congratulations, " + team1[0].TeamName + " Won. The Game will now Close", "Information", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Congratulations, " + team1[1].TeamName + " Won. The Game will now Close", "Information", MessageBoxButtons.OK);
                }
            }


        }

        private void Cricket_Game_Load(object sender, EventArgs e)
        {
            rtb1_CG.Clear();
            rtb1_CG.AppendText("Team 1 Information");
            rtb1_CG.AppendText("\n");
            rtb1_CG.AppendText(team1[0].TeamName);
            for (int j = 0; j<5; j++)
            {
                rtb1_CG.AppendText(team1[0].Players[j].playerStat());
            }
            rtb3_CG.Clear();
            rtb3_CG.AppendText("Team 2 Information");
            rtb3_CG.AppendText("\n");
            rtb3_CG.AppendText(team1[1].TeamName);
            for (int j = 0; j < 5; j++)
            {
                rtb3_CG.AppendText(team1[1].Players[j].playerStat());
            }

        }

    }
}

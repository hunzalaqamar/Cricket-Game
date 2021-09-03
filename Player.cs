using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Q1
{
    public class Player
    {
        string _playerName;
        int _playerBattingSkills;
        int _playerFieldingSkills;
        int _playerBowlingSkills;
        int _playerScore;
        string _playerStatus = "Not Out";
        int _ballsPlayed;
        string _playerMatchInfo;

        public Player(string pname = "", int pbattingskills = 0, int pfieldingskills = 0, int pbowlingskills = 0, int pscore = 0, string pstatus = "", int ballsplayed = 0, string pmatchinfo = "")
        {
            this.PlayerName = pname;
            this.PlayerBattingSkills = pbattingskills;
            this.PlayerFieldingSkills = pfieldingskills;
            this.PlayerBowlingSkills = pbowlingskills;
            this.PlayerScore = pscore;
            this.PlayerStatus = pstatus;
            this.BallsPlayed = ballsplayed;
            this.PlayerMatchInfo = pmatchinfo;
        }

        public override string ToString()
        {
            return String.Format("\nPlayer Name = {0}\nPlayer Batting Power = {1}\nPlayer Fielding Power = {2}\nPlayer Bowling Power = {3}\nPlayer Score = {4}\nPlayer Status = {5}\nPlayer Match Info = {6}", this.PlayerName, this.PlayerBattingSkills, this.PlayerFieldingSkills, this.PlayerBowlingSkills, this.PlayerScore, this.PlayerStatus, this.PlayerMatchInfo);
        }
        public string playerStat()
        {
            return String.Format("\nPlayer Name = {0}\nPlayer Batting Power = {1}\nPlayer Fielding Power = {2}\nPlayer Bowling Power = {3}\nPlayer Score = {4}\n", this.PlayerName, this.PlayerBattingSkills, this.PlayerFieldingSkills, this.PlayerBowlingSkills, this.PlayerScore);
        }

        public int PlayerBattingSkills { get => _playerBattingSkills; set => _playerBattingSkills = value; }
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public int PlayerFieldingSkills { get => _playerFieldingSkills; set => _playerFieldingSkills = value; }
        public int PlayerBowlingSkills { get => _playerBowlingSkills; set => _playerBowlingSkills = value; }
        public int PlayerScore { get => _playerScore; set => _playerScore = value; }
        public string PlayerStatus { get => _playerStatus; set => _playerStatus = value; }
        public int BallsPlayed { get => _ballsPlayed; set => _ballsPlayed = value; }
        public string PlayerMatchInfo { get => _playerMatchInfo; set => _playerMatchInfo = value; }
    }
}

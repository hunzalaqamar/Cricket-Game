using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Q1
{
    public class Team
    {
        private string _teamName;
        private Player[] players = new Player[5];

        public Team (string tname = "")
        {
            players[0] = new Player();
            players[1] = new Player();
            players[2] = new Player();
            players[3] = new Player();
            players[4] = new Player();
            this.TeamName = tname;
        }

        public string display()
        {
            return this.TeamName +"\n"+ players.ToString();

        }

        public Player[] Players { get => players; set => players = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }
    }
}

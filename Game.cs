//hi my name is laura. this is lab 7 step 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Games
    {
//these are variables 
        public string team1;
        public string team2;
        public int team1Score;
        public int team2Score;

        public Games() { }

        public Games(string team1, string team2, int team1Score, int team2Score)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }
//this is a toString method
        public override string ToString()
        {
            return String.Format(team1 + " " + "(" + team1Score + ")" + " " + " - " + " " + team2 + " " + "(" + team2Score + ")");

        }
    }
}

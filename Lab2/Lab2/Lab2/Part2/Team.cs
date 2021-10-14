using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class Team
    {
        private string teamName;
        private int forGoals;
        private int againstGoals;

        public Team()
        {
        }

        public Team(string teamName, int forGoals, int againstGoals)
        {
            this.teamName = teamName;
            this.forGoals = forGoals;
            this.againstGoals = againstGoals;
        }

        public string getTeamName()
        {
            return teamName;
        }

        public int getForGoals()
        {
            return forGoals;
        }

        public int getAgainstGoals()
        {
            return againstGoals;
        }
    }
}
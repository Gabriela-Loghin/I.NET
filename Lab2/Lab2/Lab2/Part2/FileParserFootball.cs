using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab2
{
    internal static class FileParserFootball
    {
        public static void GetMinDifference(List<Team> teams)
        {
            Team minDifferenceTeam = null;
            int minDifference = -1;
            foreach (Team team in teams)
            {
                int difference = Math.Abs(team.getForGoals() - team.getAgainstGoals());
                if (difference < minDifference || minDifference == -1)
                {
                    minDifferenceTeam = team;
                    minDifference = difference;
                }
            }
            Console.WriteLine(string.Format("Team {0} has the minimum difference in goals : {1}", minDifferenceTeam.getTeamName(), minDifference));
        }

        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();
            string path = Directory.GetCurrentDirectory();
            using (var sr = new StreamReader("D:/facultate 2/SEM5C/Lab2/Lab2/football.dat"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] columns = line.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length > 0)
                    {
                        int forGoals, againstGoals;
                        bool parseErrorFor = int.TryParse(columns[6], out forGoals);
                        bool parseErrorAgainst = int.TryParse(columns[7], out againstGoals);
                        if (parseErrorFor && parseErrorAgainst)
                        {
                            teams.Add(new Team(columns[1], forGoals, againstGoals));
                        }
                    }
                    line = sr.ReadLine();
                }
            }
            return teams;
        }
    }
}
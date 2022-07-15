using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            string creator;
            string teamName;

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] teamNameAndCreator = Console.ReadLine().Split("-");

                creator = teamNameAndCreator[0];
                teamName = teamNameAndCreator[1];

                if (teams.Any(team => team.NameOfTeam == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");

                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");

                }
                else
                {
                    Team team = new Team();
                    team.Creator = creator;
                    team.NameOfTeam=teamName;
                    team.Members=new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");

                }



            }
            while (true)
            {
                string[] userJoiningTeam = Console.ReadLine().Split("->");

                if (userJoiningTeam[0] == "end of assignment")
                {
                    break;
                }
                string user = userJoiningTeam[0];
                string teamToJoin = userJoiningTeam[1];


                   if (teams.Any(team => team.Members.Contains(user))|| teams.Any(creator=>creator.Creator==user))

                   {
                            Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                            

                   }
                   else if (teams.All(team=>team.NameOfTeam!=teamToJoin))
                   {
                            Console.WriteLine($"Team {teamToJoin} does not exist!");
                   }
                   else
                   {
                            Team currentTeam = teams.Find(team=>team.NameOfTeam==teamToJoin);

                            currentTeam.Members.Add(user);
                            
                   }
                    
                

            }

            var completedTeams = teams.Where(team => team.Members.Count > 0).ToList();
            var teamsToDisband = teams.Where(team=> team.Members.Count == 0).ToList();

            completedTeams= completedTeams.OrderByDescending(team=>team.Members.Count).ThenBy(team=>team.NameOfTeam).ToList();
            teamsToDisband = teamsToDisband.OrderBy(team => team.NameOfTeam).ToList();
            
            foreach (var team in completedTeams)
            {

            Console.WriteLine(team.NameOfTeam);
            Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");

                }
            }

            Console.WriteLine($"Teams to disband:");
            foreach (var disbanedTeam in teamsToDisband)
            {
            Console.WriteLine(disbanedTeam.NameOfTeam);

            }

        }

        public class Team
        {
            

            public string NameOfTeam { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
            

        }
    }
}

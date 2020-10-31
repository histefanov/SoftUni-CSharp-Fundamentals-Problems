using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamsCount = int.Parse(Console.ReadLine());
            string input = string.Empty;

            for (int i = 0; i < teamsCount; i++)
            {
                input = Console.ReadLine();
                string[] inputInfo = input.Split('-');
                string creator = inputInfo[0];
                string teamName = inputInfo[1];

                if (teams.Exists(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Exists(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    teams.Add(new Team(creator, teamName));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] inputInfo = input.Split("->");
                string user = inputInfo[0];
                string teamName = inputInfo[1];

                if (!teams.Exists(team => team.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Exists(team => team.Members.Contains(user) || team.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(team => team.Name == teamName);
                    teams[index].Members.Add(user);
                }
            }

            teams
                .Where(team => team.Members.Count > 0)
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.Name)
                .ToList()
                .ForEach(team =>
                {
                    Console.WriteLine($"{team.Name}");
                    Console.WriteLine($"- {team.Creator}");
                    team.Members
                    .OrderBy(member => member)
                    .ToList()
                    .ForEach(member => Console.WriteLine($"-- {member}"));
                });

            Console.WriteLine("Teams to disband:");
            if (teams.Exists(team => team.Members.Count == 0))
            {
                teams.Where(team => team.Members.Count == 0)
                .OrderBy(team => team.Name)
                .ToList()
                .ForEach(team => Console.WriteLine($"{team.Name}"));
            }
        }
    }

    class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.Name = teamName;
            this.Members = new List<string>();

        }
        public string Creator;
        public string Name;
        public List<string> Members;
    }
}

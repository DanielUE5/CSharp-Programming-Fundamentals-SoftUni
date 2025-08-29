public class Team
{
    public string Name { get; private set; }
    public string Creator { get; private set; }
    public List<string> Members { get; private set; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }
}

public class ProgramTeam
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();
        HashSet<string> users = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split('-');
            string user = input[0];
            string teamName = input[1];

            Team existingTeam = teams.FirstOrDefault(t => t.Name == teamName);

            if (existingTeam != null)
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (users.Contains(user))
            {
                Console.WriteLine($"{user} cannot create another team!");
            }
            else
            {
                Team newTeam = new Team(teamName, user);
                teams.Add(newTeam);
                users.Add(user);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] input = command.Split("->");
            string user = input[0];
            string teamName = input[1];

            Team team = teams.FirstOrDefault(t => t.Name == teamName);

            if (team == null)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (teams.Any(t => t.Members.Contains(user)) || users.Contains(user))
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
            }
            else
            {
                team.Members.Add(user);
                users.Add(user);
            }
        }

        var sortedTeams = teams
            .Where(t => t.Members.Count > 0)
            .OrderByDescending(t => t.Members.Count)
            .ThenBy(t => t.Name)
            .ToList();

        foreach (var team in sortedTeams)
        {
            Console.WriteLine(team.Name);
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }

        var disbandTeams = teams
            .Where(t => t.Members.Count == 0)
            .OrderBy(t => t.Name)
            .ToList();

        Console.WriteLine("Teams to disband:");
        foreach (var team in disbandTeams)
        {
            Console.WriteLine(team.Name);
        }
    }
}
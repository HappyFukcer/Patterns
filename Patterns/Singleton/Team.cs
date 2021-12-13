using System.Collections.Generic;

namespace Patterns.Singleton
{
    public class Team
    {
        // make it thread safe
        private static readonly object _lock = new object();

        private static Team team;

        private static List<TeamMember> members;

        private Team() { }

        public static Team GetTeam()
        {
            if (team is null)
            {
                lock (_lock)
                {
                    team = new Team();
                }
            }

            return team;
        }

        public List<TeamMember> AddMember(TeamMember member)
        {
            members.Add(member);

            return members;
        }
    }
}
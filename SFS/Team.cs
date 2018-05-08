using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Team
    {
        string Name;
        string club_name;
        string coach_name;
        int result;
        string senior;
        int totalresult;
       // List<int>res;

        public Team()
        {
            Name = "";
            senior = "";
            totalresult = 0;
            club_name = "";
            coach_name = "";
        }
        public Team(string name,string s,string club,string coach)
        {
            Name = name;
            senior = s;
            club_name = club;
            coach_name = coach;
            totalresult = 0;
        }

        public void setTeam(string name)
        {
            this.Name = name;
        }
        public string getTeam()
        {
            return this.Name;
        }


        public void setage(string Senior)
        {
            this.senior = Senior;
        }
        public string getage()
        {
            return this.senior;
        }
        public void setcoachname(string coach_name)
        {
            this.coach_name = coach_name;
        }
        public string getcoachname()
        {
            return this.coach_name;
        }
        public void setclubName(string club_name)
        {
            this.club_name = club_name;
        }
        public string getClubName()
        {
            return this.club_name;
        }
        public void Setresults(int result)
        {
            this.result = result;
        }
        public int getresults()
        {
            return this.result;
        }
        public int Gettotalresults()
        {
            return this.totalresult;
        }
        public void Settotalresults(int result)
        {
            this.totalresult = result;
        }

        public static Team operator +(Team b, Team c)
        {
            Team team = b;
            team.Settotalresults(b.Gettotalresults() + c.Gettotalresults());
            return team;
        }
        public static bool operator ==(Team b, Team c)
        {
            return (b.Gettotalresults() == c.Gettotalresults());
        }
        public static bool operator !=(Team b, Team c)
        {
            return (b.Gettotalresults() != c.Gettotalresults());
        }
        public static bool operator >(Team b, Team c)
        {
            return (b.Gettotalresults() > c.Gettotalresults());
        }
        public static bool operator <(Team b, Team c)
        {
            return (b.Gettotalresults() < c.Gettotalresults());
        }
        

    }
}


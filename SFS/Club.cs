using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Club
    {
        public List<Team> teamList;
        public List<Championships> champList = new List<Championships>();
        public List<Sponsers> sponsersList;
        string clubName;
        string startingDate;
        int totalresult;
        public Club()
        {
            teamList = new List<Team>();
            sponsersList = new List<Sponsers>();
            clubName = "";
            startingDate = "";
            totalresult = 0;
        }
        public Club(string club_Name, string start_Date)
        {
            clubName = club_Name;
            startingDate = start_Date;
            totalresult = 0;
        }
        public void setClubName(string clubName)
        {
            this.clubName = clubName;
        }
        public string getClubName()
        {
            return this.clubName;
        }
        public void setStartingDate(string startingDate)
        {
            this.startingDate = startingDate;

        }
        public string getStartingDate()
        {
            return this.startingDate;
        }
        public int Gettotalresults()
        {
            return this.totalresult;
        }
        public void Settotalresults(int result)
        {
            this.totalresult = result;
        }
        public static Club operator +(Club b, Club c)
        {
            Club club = b;
            club.Settotalresults(b.Gettotalresults() + c.Gettotalresults());
            return club;
        }
        public static bool operator ==(Club b, Club c)
        {
            return (b.Gettotalresults() == c.Gettotalresults());
        }
        public static bool operator !=(Club b, Club c)
        {
            return (b.Gettotalresults() != c.Gettotalresults());
        }
        public static bool operator >(Club b, Club c)
        {
            return (b.Gettotalresults() > c.Gettotalresults());
        }
        public static bool operator <(Club b, Club c)
        {
            return (b.Gettotalresults() < c.Gettotalresults());
        }
    }
}

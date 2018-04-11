using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Club
    {
        List<Team> teamList;
        List<Championships> champList;
        List<Sponsers> sponsersList;
        string clubName;
        string startingDate;
        public Club()
        {
            teamList = new List<Team>();
            champList = new List<Championships>();
            sponsersList = new List<Sponsers>();
            clubName = "";
            startingDate = "";
        }
        public Club(string club_Name, string start_Date)
        {
            clubName = club_Name;
            startingDate = start_Date;
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
    }
}

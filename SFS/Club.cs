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
        int startingDate;
        public Club()
        {
            teamList = new List<Team>();
            champList = new List<Championships>();
            sponsersList = new List<Sponsers>();
            clubName = "";
            startingDate = 0;
        }
        public Club(string club_Name, int start_Date)
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
        public void setStartingDate(int startingDate)
        {
            this.startingDate = startingDate;

        }
        public int getStartingDate()
        {
            return this.startingDate;
        }
    }
}

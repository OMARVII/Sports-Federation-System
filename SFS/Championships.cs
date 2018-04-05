using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Championships
    {

        string place;
        List<Team> teamList;
       // List<Results> teamResults;
        public Championships()
        {
            place = "";
            teamList = new List<Team>();
           // teamResults = new List<Results>();
           
        }
        public Championships(string placee)
        {
            place = placee;
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public string GetPlace()
        {
            return this.place;
        }

    }
}

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
        int results;
        public Championships()
        {
            place = "";
            teamList = new List<Team>();
            results = 0;
           
        }
        public Championships(string placee,int Results)
        {
            place = placee;
            results = Results;
            
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public string GetPlace()
        {
            return this.place;
        }
        public void setresults(int results)
        {
            this.results = results;
        }
        public int Getresults()
        {
            return this.results;
        }

    }
}

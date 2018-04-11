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
        bool senior;
       // List<int>res;

        public Team()
        {
            Name = "";
            senior = false;
        }
        public Team(string N,bool s)
        {
            Name = N;
            senior = s;
        }

        public void setTeam(string name)
        {
            this.Name = name;
        }
        public string getTeam()
        {
            return this.Name;
        }


        public void setage(bool Senior)
        {
            this.senior = Senior;
        }
        public bool getage()
        {
            return this.senior;
        }
    }
}


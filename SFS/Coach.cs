using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Coach : Employee
    {
        int result;
        public Coach()
        {
            result = 0;
        }
        public Coach(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob, int workyear, string empdate, string statue, string dep, int Expenses, string accountant,int result, string pass,string salnot,string depnot) : base(namee, date, genderr, ID, medical, sal, bon, mob, workyear, empdate, statue, dep,pass,salnot,depnot)
        {
            this.result = result;
        }
        public void setResult(int result)
        {
            this.result = result;
        }
        public int getResult()
        {
            return this.result;
        }
    }
}

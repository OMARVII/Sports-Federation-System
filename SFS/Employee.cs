using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Employee : Person
    {
        int working_year;
        string Employment_date;
        bool status;
        string department;


        public Employee()
        {
            working_year = 0;
            Employment_date = "";
            status = false;
            department = "";
            
        }
        public Employee(string x,bool y,string z, string a, string d, string g, string i, bool m, float s, float b) :base(a,d,g,i,m,s,b)
        {
            
            Employment_date = x;
            status = y;
            department = z;
        }
        public void setWorking_Year(int working_year)
        {
            this.working_year = working_year;

        }
        public int getWorking_Year()
        {
            return this.working_year;

        }
        public void setEmployment_date(string Employment_date)
        {
            this.Employment_date = Employment_date;

        }
        public string getEmployment_date()
        {
            return this.Employment_date;
        }
        public void setStatus(bool status)
        {

            this.status = status;
        }
        public bool GetStatus()
        {
            return this.status;

        }
        public void setDepartment(string department)
        {
            this.department = department;
        }
        public string GetDepartment()
        {
            return this.department;
        }
        public int Working_year_calc()
        {
            int current_year = 2018;
            int years;
            years= current_year - working_year;
            return years;
        }
 
    }
}
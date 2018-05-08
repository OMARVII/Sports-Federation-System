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
        string status;
        string department;
        string password;
        string salarynotification;
        string departmentnotification;
        public Employee()
        {
            working_year = 0;
            Employment_date = "";
            status = "Available";
            department = "";
            password = "";
            salarynotification = "NO";
            departmentnotification = "YES";
        }
        public Employee(string namee, string date, string genderr, string ID, string medical, float sal, float bon, string mob,int workyear,string empdate, string statue, string dep,string pass,string snotification,string dnotification) :base(namee,date,genderr,ID,medical,sal,bon,mob)
        {
            
            Employment_date = empdate;
            status = statue;
            department = dep;
            working_year = workyear;
            password = pass;
            salarynotification = snotification;
            departmentnotification = dnotification;
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
        public void setStatus(string status)
        {

            this.status = status;
        }
        public string GetStatus()
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
        public void setpassword(string pass)
        {
            this.password = pass;
        }
        public string Getpassword()
        {
            return this.password;
        }
        public void setsalarynot(string sal)
        {
            this.salarynotification = sal;
        }
        public string getsalarynot()
        {
            return this.salarynotification;
        }
        public void setdepnot(string dep)
        {
            this.departmentnotification = dep;
        }
        public string getdepnot()
        {
            return this.departmentnotification;
        }
        public static int Working_year_calc(DateTime d)
        {
            
              DateTime doe = Convert.ToDateTime(d);
              var today = DateTime.Today;
              var wk = today.Year - doe.Year;
              return int.Parse(wk.ToString());
        }
         public static Employee operator +(Employee b, Employee c)
        {
          Employee emp = b;
          emp.setWorking_Year(b.getWorking_Year() + c.getWorking_Year());
          return emp;
        }
        public static bool operator ==(Employee b, Employee c)
        {
          return (b.getWorking_Year() == c.getWorking_Year());
        }
        public static bool operator !=(Employee b, Employee c)
        {
          return (b.getWorking_Year() != c.getWorking_Year());
        }
        public static bool operator >(Employee b, Employee c)
        {
          return (b.getWorking_Year() > c.getWorking_Year());
        }
        public static bool operator <(Employee b, Employee c)
        {
          return (b.getWorking_Year() < c.getWorking_Year());
        }
 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    public abstract class Person
    {
        string name;
        string dateOfBirth;
        string gender;
        string id;
        bool medicalReport;
        float salary;
        float bonus;
        public Person()
        {
            name = "";
            dateOfBirth = "";
            gender = "";
            id = "";
            medicalReport = false;
            salary = 0;
            bonus = 0;
        }
        public Person(string n, string d, string g, string i, bool m, float s, float b)
        {
            name = n;
            dateOfBirth = d;
            gender = g;
            id = i;
            medicalReport = m;
            salary = s;
            bonus = b;

        }
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return this.name;
        }

        public void setDateOfBirth(string dateOfBirth)
        {

            this.dateOfBirth = dateOfBirth;

        }
        public string getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public void setGender(string gender)
        {
            this.gender = gender;

        }
        public string getGender()
        {
            return this.gender;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return this.id;
        }
        public void setMedicalReport(bool medicalReport)
        {

            this.medicalReport = medicalReport;
        }
        public bool getMedicalReport()
        {
            return this.medicalReport;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
        public float getSalary()
        {
            return this.salary;

        }
        public void setbonus(float bonus)
        {
            this.bonus = bonus;
        }
        public float getBonus()
        {
            return this.bonus;
        }

        public int ageCalculator()
        {

            return 18 - int.Parse(getDateOfBirth().Substring(7));
        }
        public virtual void displayInfo()
        {

        }

    }
}
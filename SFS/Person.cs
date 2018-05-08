using System;

namespace SFS
{
    public abstract class Person
    {
        string name;
        string dateOfBirth;
        string gender;
        string id;
        string medicalReport;
        float salary;
        float bonus;
        string mobile;
        static public int count1=0;
        static public int count2 = 0;

        public Person()
        {
            name = "";
            dateOfBirth = "";
            gender = "";
            id = "";
            medicalReport = "NO";
            salary = 0;
            bonus = 0;
        }
        public Person(string namee, string date, string genderr, string ID, string medical, float sal, float bon,string mob)
        {
            name = namee;
            dateOfBirth = date;
            gender = genderr;
            id = ID;
            medicalReport = medical;
            salary = sal;
            bonus = bon;
            mobile = mob;
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
        public void setMedicalReport(string medicalReportt)
        {

            this.medicalReport = medicalReportt;
        }
        public string getMedicalReport()
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
            DateTime dob = Convert.ToDateTime(dateOfBirth);
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return int.Parse(age.ToString());
        }
        public virtual void displayInfo()
        {

        }
        public void setmobile(string mobile)
        {
            this.mobile = mobile;
        }
        public string getmobile()
        {
            return this.mobile;

        }
    }
}
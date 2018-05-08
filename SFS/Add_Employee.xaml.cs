using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    /// <summary>
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || number.Text == "" || Salary.Text == "" || Emplyedate.Text == "" || Date.Text == "" || Department.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if ((Male.IsChecked == false) && (Female.IsChecked == false))
                MessageBox.Show("Please fill the required information !");
            else if ((Yes.IsChecked == false) && (No.IsChecked == false))
                MessageBox.Show("Please fill the required information !");
            else if ((Yes3.IsChecked == false) && (No3.IsChecked == false))
                MessageBox.Show("Please fill the required information !");
            else if (number.Text.Length != 11)
            {
                MessageBox.Show("Please Enter Valid Mobile Number!");
            }

            else
            {
                string dep = "";
                if (Department.Text == "HR")
                {
                    if (adminlogin.admin == true)
                    {
                        dep = "HR";
                    }
                }
                else if (Department.Text == "Coach")
                {
                    dep = "Coach";
                }
                else if (Department.Text == "Accounting")
                {
                    dep = "Accounting";
                }
                string gender = "";
                string med;
                string avail;
                int y = int.Parse(Emplyedate.Text.Substring(6));

                double sal = double.Parse(Salary.Text);

                DateTime doe = Convert.ToDateTime(Emplyedate.Text);
                int yyear = doe.Year;
                int today = DateTime.Today.Year;
                int x = today - yyear;
                string working_years = x.ToString();
                double bon = 0;
                if(x>5)
                {
                    double b = x / 5;
                    bon = ((b * 0.2) * sal);
                }
                string temp = Date.Text;
                string temp2 = Name.Text;
                string id = "";
                // temp2[0].ToString() + temp2[1].ToString() + temp[temp.Count() - 2].ToString() + temp[temp.Count()-1].ToString();
                Person.count1++;
                if (temp.Length == 10)
                {
                    id = Person.count1 + temp2[0].ToString() + temp2[1].ToString() + temp[8].ToString() + temp[9].ToString();
                }
                else if (temp.Length == 9)
                {
                    id = Person.count1 + temp2[0].ToString() + temp2[1].ToString() + temp[7].ToString() + temp[8].ToString();
                }
                else if (temp.Length == 8)
                {
                    id = Person.count1 + temp2[0].ToString() + temp2[1].ToString() + temp[6].ToString() + temp[7].ToString();
                }
                string generatedpass = id;

                if (Male.IsChecked == true)
                    gender = "Male";
                else gender = "Female";

                if (Yes.IsChecked == true)
                    med = "YES";
                else
                    med = "NO";

                if (Yes3.IsChecked == true)
                    avail = "Yes";
                else avail = "No";
                Employee emp = new Employee(Name.Text, Date.Text, gender, id, med, float.Parse(Salary.Text), 0, number.Text, x, Emplyedate.Text, avail, dep, generatedpass,"NO","NO");

                bool mobile = false;
                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getmobile() == number.Text)
                    {
                        mobile = true;
                    }
                }
                for (int i = 0; i < Containers.Player_list.Count(); i++)
                {
                    if (Containers.Player_list[i].getmobile() == number.Text)
                    {
                        mobile = true;
                    }
                }
                if (mobile == true)
                {
                    MessageBox.Show("Please Re-enter Mobile Number !");

                }

                else
                {

                    Containers.Employee_list.Add(emp);
                    if (dep != "")
                    {

                        if (!File.Exists("Employees.xml"))
                        {
                            XmlTextWriter document = new XmlTextWriter("Employees.xml", Encoding.UTF8);

                            document.Formatting = Formatting.Indented;
                            document.WriteStartDocument();
                            document.WriteStartElement("Employees");
                            document.WriteStartElement("Employee");
                            document.WriteStartElement("Employee_Name");
                            document.WriteString(Name.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Employment_ID");
                            document.WriteString(id);
                            document.WriteEndElement();

                            document.WriteStartElement("Mobile_Number");
                            document.WriteString(number.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Gender");
                            document.WriteString(gender);
                            document.WriteEndElement();

                            document.WriteStartElement("Medical_Form");
                            document.WriteString(med);
                            document.WriteEndElement();

                            document.WriteStartElement("Salary");
                            document.WriteString(Salary.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Bonus");
                            document.WriteString(bon.ToString());
                            document.WriteEndElement();

                            document.WriteStartElement("Employement_Date");
                            document.WriteString(Emplyedate.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Working_Years");
                            document.WriteString(working_years);
                            document.WriteEndElement();

                            document.WriteStartElement("Date_of_birth");
                            document.WriteString(Date.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Available");
                            document.WriteString(avail);
                            document.WriteEndElement();

                            document.WriteStartElement("Department");
                            document.WriteString(dep);
                            document.WriteEndElement();

                            document.WriteStartElement("Password");
                            document.WriteString(generatedpass);
                            document.WriteEndElement();

                            document.WriteStartElement("Salary_Notification");
                            document.WriteString("NO");
                            document.WriteEndElement();

                            document.WriteStartElement("Department_Notification");
                            document.WriteString("NO");
                            document.WriteEndElement();

                            document.WriteEndElement();
                            document.WriteEndElement();
                            document.WriteEndDocument();

                            document.Close();

                            MessageBox.Show("Employee Successfuly Added.");
                        }
                        else

                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load("Employees.xml");

                            XmlNode employee = doc.CreateElement("Employee");

                            XmlNode Employee_Name = doc.CreateElement("Employee_Name");
                            Employee_Name.InnerText = Name.Text;
                            employee.AppendChild(Employee_Name);

                            XmlNode Employee_ID = doc.CreateElement("Employeement_ID");
                            Employee_ID.InnerText = id;
                            employee.AppendChild(Employee_ID);

                            XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                            MobileNum.InnerText = number.Text;
                            employee.AppendChild(MobileNum);

                            XmlNode Genderr = doc.CreateElement("Gender");
                            Genderr.InnerText = gender;
                            employee.AppendChild(Genderr);

                            XmlNode Medical = doc.CreateElement("Medical_Form");
                            Medical.InnerText = med;
                            employee.AppendChild(Medical);

                            XmlNode salary = doc.CreateElement("Salary");
                            salary.InnerText = Salary.Text;
                            employee.AppendChild(salary);

                            XmlNode b = doc.CreateElement("Bonus");
                            b.InnerText = bon.ToString();
                            employee.AppendChild(b);

                            XmlNode Employementdate = doc.CreateElement("Employement_Date");
                            Employementdate.InnerText = Emplyedate.Text;
                            employee.AppendChild(Employementdate);

                            XmlNode workingyears = doc.CreateElement("Working_Years");
                            workingyears.InnerText = working_years;
                            employee.AppendChild(workingyears);

                            XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                            dateofbirth.InnerText = Date.Text;
                            employee.AppendChild(dateofbirth);

                            XmlNode avaliable = doc.CreateElement("Available");
                            avaliable.InnerText = avail;
                            employee.AppendChild(avaliable);

                            XmlNode depp = doc.CreateElement("Department");
                            depp.InnerText = Department.Text;
                            employee.AppendChild(depp);

                            XmlNode pas = doc.CreateElement("Password");
                            pas.InnerText = generatedpass;
                            employee.AppendChild(pas);

                            XmlNode saln = doc.CreateElement("Salary_Notification");
                            saln.InnerText = "NO";
                            employee.AppendChild(saln);

                            XmlNode depnot = doc.CreateElement("Department_Notification");
                            depnot.InnerText = "NO";
                            employee.AppendChild(depnot);

                            doc.DocumentElement.AppendChild(employee);
                            doc.Save("Employees.xml");

                            MessageBox.Show("Employee Successfuly Added.");
                        }

                        if (Department.Text == "Coach")
                        {
                            if (!File.Exists("Coaches.xml"))
                            {
                                XmlTextWriter document = new XmlTextWriter("Coaches.xml", Encoding.UTF8);

                                document.Formatting = Formatting.Indented;
                                document.WriteStartDocument();
                                document.WriteStartElement("Coaches");
                                document.WriteStartElement("Coach");
                                document.WriteStartElement("Coach_Name");
                                document.WriteString(Name.Text);
                                document.WriteEndElement();

                                document.WriteStartElement("Coach_ID");
                                document.WriteString(id);
                                document.WriteEndElement();

                                document.WriteStartElement("Mobile_Number");
                                document.WriteString(number.Text);
                                document.WriteEndElement();

                                document.WriteStartElement("Gender");
                                document.WriteString(gender);
                                document.WriteEndElement();

                                document.WriteStartElement("Medical_Form");
                                document.WriteString(med);
                                document.WriteEndElement();

                                document.WriteStartElement("Salary");
                                document.WriteString(Salary.Text);
                                document.WriteEndElement();

                                document.WriteStartElement("Bonus");
                                document.WriteString(bon.ToString());
                                document.WriteEndElement();

                                document.WriteStartElement("Employement_Date");
                                document.WriteString(Emplyedate.Text);
                                document.WriteEndElement();

                                document.WriteStartElement("Working_Years");
                                document.WriteString(working_years);
                                document.WriteEndElement();

                                document.WriteStartElement("Date_of_birth");
                                document.WriteString(Date.Text);
                                document.WriteEndElement();

                                document.WriteStartElement("Available");
                                document.WriteString(avail);
                                document.WriteEndElement();

                                document.WriteStartElement("Department");
                                document.WriteString(dep);
                                document.WriteEndElement();

                                document.WriteStartElement("Results");
                                document.WriteString("0");
                                document.WriteEndElement();


                                document.WriteStartElement("Password");
                                document.WriteString(generatedpass);
                                document.WriteEndElement();

                                document.WriteEndElement();
                                document.WriteEndElement();
                                document.WriteEndDocument();

                                document.Close();

                                MessageBox.Show("Coach Successfuly Added.");
                            }
                            else

                            {
                                XmlDocument doc = new XmlDocument();
                                doc.Load("Coaches.xml");

                                XmlNode employee = doc.CreateElement("Coach");

                                XmlNode Employee_Name = doc.CreateElement("Coach_Name");
                                Employee_Name.InnerText = Name.Text;
                                employee.AppendChild(Employee_Name);

                                XmlNode Employee_ID = doc.CreateElement("Coach_ID");
                                Employee_ID.InnerText = id;
                                employee.AppendChild(Employee_ID);

                                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                                MobileNum.InnerText = number.Text;
                                employee.AppendChild(MobileNum);

                                XmlNode Genderr = doc.CreateElement("Gender");
                                Genderr.InnerText = gender;
                                employee.AppendChild(Genderr);

                                XmlNode Medical = doc.CreateElement("Medical_Form");
                                Medical.InnerText = med;
                                employee.AppendChild(Medical);

                                XmlNode salary = doc.CreateElement("Salary");
                                salary.InnerText = Salary.Text;
                                employee.AppendChild(salary);

                                XmlNode b = doc.CreateElement("Bonus");
                                b.InnerText = bon.ToString();
                                employee.AppendChild(b);

                                XmlNode Employementdate = doc.CreateElement("Employement_Date");
                                Employementdate.InnerText = Emplyedate.Text;
                                employee.AppendChild(Employementdate);

                                XmlNode workingyears = doc.CreateElement("Working_Years");
                                workingyears.InnerText = working_years;
                                employee.AppendChild(workingyears);

                                XmlNode dateofbirth = doc.CreateElement("Date_of_birth");
                                dateofbirth.InnerText = Date.Text;
                                employee.AppendChild(dateofbirth);

                                XmlNode avaliable = doc.CreateElement("Available");
                                avaliable.InnerText = avail;
                                employee.AppendChild(avaliable);

                                XmlNode depp = doc.CreateElement("Department");
                                depp.InnerText = dep;
                                employee.AppendChild(depp);

                                XmlNode res = doc.CreateElement("Results");
                                res.InnerText = "0";
                                employee.AppendChild(res);

                                XmlNode pas = doc.CreateElement("Password");
                                pas.InnerText = generatedpass;
                                employee.AppendChild(pas);

                                doc.DocumentElement.AppendChild(employee);
                                doc.Save("Coaches.xml");

                                MessageBox.Show("Coach Successfuly Added.");
                            }

                        }
                        Containers.write_counter1();
                    }
                    else
                    {
                        MessageBox.Show("You're not allowed to add HR !");
                    }
                }
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
            this.Close();
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void Male_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(number.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                number.Text = number.Text.Remove(number.Text.Length - 1);
            }
        }

        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Salary.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                Salary.Text = Salary.Text.Remove(Salary.Text.Length - 1);
            }
        }
    }
}


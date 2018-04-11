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
            string gender;
            string med;
            string avail;
            int y = int.Parse(Emplyedate.Text.Substring(6));
            int x = 18 - y;
            int sal = int.Parse(Salary.Text);
            int per = x / 5;
            string working_years = x.ToString();
            int bonu = 0;
            if(x>5)
            {
                 bonu = (per * sal) / 100;
            }
            string bonus = bonu.ToString();
            // string ID =  Name.Text.ElementAt(0)+ Name.Text.ElementAt(1) +Date.Text.ElementAt(6) + Date.Text.ElementAt(7);
            string temp = Date.Text;
            string temp2=Name.Text;
            string id = temp2[0].ToString() + temp2[1].ToString() + temp[6].ToString() + temp[7].ToString();
          //  MessageBox.Show(id);
            if (Male.IsChecked == true)
                gender = "Male";
            else gender = "Female";

            if (Yes.IsChecked == true)
                med = "Yes";
            else med = "No";
           
            if (Yes3.IsChecked == true)
                avail = "Yes";
            else avail = "No";

            if (Name.Text == "" || number.Text == "" || Salary.Text == "" || Emplyedate.Text == ""|| Date.Text==""|| Department.Text=="")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if((Male.IsChecked == true)&& (Female.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
           else if ((Yes.IsChecked == true) && (No.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
          
           else  if (!File.Exists("Employees.xml"))
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
                document.WriteString(bonus);
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
                document.WriteString(Department.Text);
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
                b.InnerText = bonus;
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

                XmlNode dep = doc.CreateElement("Department");
                dep.InnerText = Department.Text;
                employee.AppendChild(dep);

                doc.DocumentElement.AppendChild(employee);
                doc.Save("Employees.xml");

                MessageBox.Show("Employee Successfuly Added.");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
        }

        private void ID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }


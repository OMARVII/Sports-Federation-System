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
    /// Interaction logic for Add_Player.xaml
    /// </summary>
    public partial class Add_Player : Window
    {
        public Add_Player()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string gender;
            string med;
            int x= 0;
            string bou=x.ToString();
          
            /* string temp = Date.Text;
             string id = temp[8].ToString() + temp[9].ToString();*/
            if (male.IsChecked == true)
                gender = "Male";
            else gender = "Female";
            if (yes.IsChecked == true)
                med = "Yes";
            else med = "No";
            string temp = Date.Text;
            string temp2 = Name.Text;
            string id = temp2[0].ToString() + temp2[1].ToString() + temp[7].ToString() + temp[8].ToString();

            if (Name.Text == "" || Number.Text == "" || Salary.Text == "" || team_name.Text == "" || Date.Text == "" )
            {
                MessageBox.Show("Please fill the required information !");
            }
           else if ((male.IsChecked == true) && (female.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
            else if ((yes.IsChecked == true) && (no.IsChecked == true))
                MessageBox.Show("Please fill the required information !");


           // Player newplayer = new Player(team_name.Text,Name.Text,Date.Text,gender,id,med,);


           else if (!File.Exists("Players.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Players.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Players");
                document.WriteStartElement("Player");

                document.WriteStartElement("Player_Name");
                document.WriteString(Name.Text);
                document.WriteEndElement();

                document.WriteStartElement("Player_ID");
                document.WriteString(id);
                document.WriteEndElement(); 

                document.WriteStartElement("Mobile_Number");
                document.WriteString(Number.Text);
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
                document.WriteString(bou);
                document.WriteEndElement();

                document.WriteStartElement("Date_of_birth");
                document.WriteString(Date.Text);
                document.WriteEndElement();

                document.WriteStartElement("Team_Name");
                document.WriteString(team_name.Text);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

                MessageBox.Show("Player Successfuly Added.");
            }
           else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");
                
                XmlNode playerr = doc.CreateElement("Player");

                XmlNode Player_Name = doc.CreateElement("Player_Name");
                Player_Name.InnerText =Name.Text;
                playerr.AppendChild(Player_Name);

                XmlNode ID = doc.CreateElement("Player_ID");
                ID.InnerText = id;
                playerr.AppendChild(ID);

                XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                MobileNum.InnerText = Number.Text;
                playerr.AppendChild(MobileNum);
                
                XmlNode Genderr = doc.CreateElement("Gender");
                Genderr.InnerText = gender;
                playerr.AppendChild(Genderr);

                XmlNode Medical = doc.CreateElement("Medical_Form");
                Medical.InnerText = med;
                playerr.AppendChild(Medical);

                XmlNode salary = doc.CreateElement("Salary");
                salary.InnerText = Salary.Text;
                playerr.AppendChild(salary);

                XmlNode bonus = doc.CreateElement("Bonus");
                bonus.InnerText = bou;
                playerr.AppendChild(bonus);

                XmlNode dateofbirth = doc.CreateElement("Date_oF_birth");
                dateofbirth.InnerText = Date.Text;
                playerr.AppendChild(dateofbirth);

                XmlNode teamm = doc.CreateElement("Team_Name");
                teamm.InnerText = team_name.Text;
                playerr.AppendChild(teamm);

                doc.DocumentElement.AppendChild(playerr);
                doc.Save("Players.xml");

                MessageBox.Show("Player Successfuly Added.");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
        }

        private void yes_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    }


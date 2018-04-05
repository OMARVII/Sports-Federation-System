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
            string bou;
            string sen;
            if (male.IsChecked == true)
                gender = "Male";
            else gender = "Female";
            if (yes.IsChecked == true)
                med = "Yes";
            else med = "No";
            if (yes2.IsChecked == true)
                bou = "Yes";
            else bou = "No";

            if (Senior.IsChecked == true)
                sen = "Yes";
            else sen = "No";

            if (!File.Exists("Players.xml"))
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
                document.WriteString(Id.Text);
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

                document.WriteStartElement("Senior");
                document.WriteString(sen);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();
            }
           else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Players.xml");
                
                XmlNode playerr = doc.CreateElement("Player");

                XmlNode Player_Name = doc.CreateElement("Player_Name");
                Player_Name.InnerText =Name.Text;
                playerr.AppendChild(Player_Name);

                XmlNode player_id = doc.CreateElement("Player_ID");
                player_id.InnerText = Id.Text;
                playerr.AppendChild(player_id);

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

                XmlNode seniorr = doc.CreateElement("Senior");
                seniorr.InnerText = sen;
                playerr.AppendChild(seniorr);

                doc.DocumentElement.AppendChild(playerr);
                doc.Save("Players.xml");
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Chooose cccc = new Chooose();
            cccc.Show();
        }
    }
    }


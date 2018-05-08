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
    /// Interaction logic for Add__Team.xaml
    /// </summary>
    public partial class Add__Team : Window
    {
        public Add__Team()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {

            bool found = false;
            bool name = false;
            bool clubbl = false;
            string sen = "";
            if (names.Text == "Women" || names.Text == "Men")
                sen = "Senior";
            else sen = "Junior";

            if (names.Text == "" || club.Text == "" || coach.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else
            {
                
                for (int i = 0; i < Containers.Coach_list.Count; i++)
                {
                    if (coach.Text == Containers.Coach_list[i].getName())
                    {
                        name = true;
                    }

                }

                for (int i = 0; i < Containers.Club_list.Count; i++)
                {
                    if (club.Text == Containers.Club_list[i].getClubName())
                    {
                        clubbl = true;
                    }

                }
                if(clubbl == false)
                {
                    MessageBox.Show("Club Does not Exists !");
                }
                else if (name == true&& clubbl == true)
                {
                    for (int i = 0; i < Containers.Team_list.Count; i++)
                    {

                        if ((names.Text == Containers.Team_list[i].getTeam()) && (coach.Text == Containers.Team_list[i].getcoachname()) && (club.Text == Containers.Team_list[i].getClubName()))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        MessageBox.Show("Team Already Exists !");
                    }
                    else
                    {
                        Team added = new Team(names.Text,sen,  club.Text, coach.Text);
                        Containers.Team_list.Add(added);
                        if (!File.Exists("Teams.xml"))
                        {
                            XmlTextWriter document = new XmlTextWriter("Teams.xml", Encoding.UTF8);

                            document.Formatting = Formatting.Indented;
                            document.WriteStartDocument();
                            document.WriteStartElement("Teams");
                            document.WriteStartElement("Team");

                            document.WriteStartElement("Team_Name");
                            document.WriteString(names.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Club_Name");
                            document.WriteString(club.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Coach_Name");
                            document.WriteString(coach.Text);
                            document.WriteEndElement();

                            document.WriteStartElement("Senior");
                            document.WriteString(sen);
                            document.WriteEndElement();

                            document.WriteEndElement();
                            document.WriteEndElement();
                            document.WriteEndDocument();

                            document.Close();

                            MessageBox.Show("Team Successfuly added.");

                        }
                        else

                        {
                            added = new Team(names.Text, coach.Text, sen, club.Text);
                            Containers.Team_list.Add(added);
                            XmlDocument doc = new XmlDocument();
                            doc.Load("Teams.xml");

                            XmlNode team = doc.CreateElement("Team");

                            XmlNode team_Name = doc.CreateElement("Team_Name");
                            team_Name.InnerText = names.Text;
                            team.AppendChild(team_Name);

                            XmlNode club_Name = doc.CreateElement("Club_Name");
                            club_Name.InnerText = club.Text;
                            team.AppendChild(club_Name);

                            XmlNode coach_name = doc.CreateElement("Coach_Name");
                            coach_name.InnerText = coach.Text;
                            team.AppendChild(coach_name);

                            XmlNode senior = doc.CreateElement("Senior");
                            senior.InnerText = sen;
                            team.AppendChild(senior);

                            doc.DocumentElement.AppendChild(team);
                            doc.Save("Teams.xml");

                            MessageBox.Show("Team Successfuly added.");
                        }


                    }
                }

            
        

              else{
                MessageBox.Show("Coach doesn't exist ! ");
            }
        }
    }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options aa = new Add_Options();
            aa.Show();
            this.Close();
        }

        private void Results_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}

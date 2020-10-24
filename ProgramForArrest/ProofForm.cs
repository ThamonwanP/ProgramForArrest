using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForArrest
{
    public partial class ProofForm : Form
    {
        string card;
        string imagesStr;
        public ProofForm(string tbMCard)
        {
            InitializeComponent();
            card = tbMCard;
            //MessageBox.Show(card);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProofForm_Load(object sender, EventArgs e)
        {
            try
            {

                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                RestRequest Getrequest = new RestRequest("/ArrestSystem/persons/" + card);
                var getPersons = Getclient.Execute<List<SearchPersons_data>>(Getrequest, Method.GET);

                //tbPersonTitle.Text = getPersons.Data[0].title;
                tbPersonCard.Text = getPersons.Data[0].card;
                tbPersonFirstname.Text = getPersons.Data[0].firstname;
                tbUserLastname.Text = getPersons.Data[0].lastname;
                tbPersonPhone.Text = getPersons.Data[0].phone;
                tbPersonGroup.Text = getPersons.Data[0].group;


                var pic = Convert.FromBase64String(getPersons.Data[0].image_url);
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    pictureBox_Person.Image = Image.FromStream(ms);
                }
                imagesStr = getPersons.Data[0].image_url;
                //Console.WriteLine(imagesStr);
                MessageBox.Show(getPersons.Data[0].id);

                try
                {
                            
                            RestRequest request = new RestRequest("/ArrestSystem/person/event/" + getPersons.Data[0].id);
                            var getEvent = Getclient.Execute<List<GetEventData>>(request, Method.GET);

                            //string selectCard = listView_Events.SelectedItems[0].SubItems[0].Text;
                            int i = 0;

                            while (getEvent.Data.Count > i)
                            {
                                DateTime bdate = UnixTimeStampToDateTime(getEvent.Data[i].date.value);
                                string time = bdate.ToString("yyyy-MM-dd");

                                string[] Persons = new string[]
                                {
                                        time,
                                        getEvent.Data[i].casestr,
                                        getEvent.Data[i].other,
                                        pictureBox1.ImageLocation = getEvent.Data[i].image
                                 };
                                listView_Events.Items.Add(new ListViewItem(Persons));
                                             
                                i++;
                            }
                }
                catch { }
                
            }
            catch { }

        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void listView_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectCard = listView_Events.SelectedItems[0].SubItems[0].Text;

                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/person/event/" + tbPersonCard.Text);
                var getEvent = Getclient.Execute<List<GetEventData>>(request, Method.GET);

                //Console.WriteLine(tbUserCard.Text);
                if (listView_Events.SelectedItems[0].SubItems[0].Text != null)
                {

                    var pic = Convert.FromBase64String(getEvent.Data[0].image);
                    using (MemoryStream ms = new MemoryStream(pic))
                    {
                        pictureBox_Person.Image = Image.FromStream(ms);
                    }
                }

            }
            catch { }
        }
    }
}

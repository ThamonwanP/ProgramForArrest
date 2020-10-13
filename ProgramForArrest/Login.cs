using ProgramForArrest.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace ProgramForArrest
{
   
    public partial class Login : Form
    { 

        public Login()
        {
            InitializeComponent();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
           
               
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/userlogin");
                LoginData input = new LoginData();
            
            
                input.card = tbCard.Text;
                input.password = tbPassword.Text;
             
            if (!tbCard.Text.Equals("") && !tbPassword.Text.Equals("")) {
                
                var serializer = new JavaScriptSerializer();
                string jsonStr = serializer.Serialize(input);
                request.AddJsonBody(jsonStr);
                var userData =  client.Execute<List<LoginResult_Userinfo>>(request, Method.POST);
            

                if (userData.Data != null)
                {
                    RestClient GetClient = new RestClient("http://202.28.34.197:8800");
                    RestRequest GetRequest = new RestRequest("/fingerprintSystem/search/user/" + userData.Data[0].organization);
                    var getOrg = GetClient.Execute<List<searchOrganizationData>>(GetRequest, Method.GET);
                    HomeForm home = new HomeForm(input.card, input.password, getOrg.Data[0].id);
                    home.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("ไม่ถูกต้อง! กรุณาตรวจสอบใหม่อีกครั้ง");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }

        }

        private void tbCard_Click(object sender, EventArgs e)
        {
            //tbCard.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}

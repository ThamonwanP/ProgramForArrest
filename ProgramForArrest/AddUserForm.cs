using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ProgramForArrest
{
    public partial class AddUserForm : Form
    {
        string card;
        //string password;
        public AddUserForm(string card)
        {
            InitializeComponent();
            this.card = card;
            //this.password = password;
            Console.WriteLine("Data = " + this.card);
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
           
            try
            {
                AddUserbyAdmin input = new AddUserbyAdmin();
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/users");

                input.admincard = this.card;
                input.title = tbUserTitle.Text;
                input.firstname = tbUserFristname.Text;
                input.lastname = tbUserLastname.Text;
                input.card = tbUserCard.Text;
                input.date = tbUserBirthday.Value.ToString("yyyy-MM-dd");
                input.position = tbUserPosition.Text;
                input.organization = tbUserOrganization.Text;
                input.email = tbUserEmail.Text;
                input.phone = tbUserPhone.Text;
                input.address = tbUserAddress.Text;
                input.image_url = openFileDialog_User.FileName;

                var serializer = new JavaScriptSerializer();
                string jsonStr = serializer.Serialize(input);
                request.AddJsonBody(jsonStr);
                var AddUser = client.Execute<UpdateUserResult>(request, Method.POST);

                Console.WriteLine(AddUser);

                MessageBox.Show("เปลี่ยนข้อมูลสำเร็จ! ");
            }
            catch { }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

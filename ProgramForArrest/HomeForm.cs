using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using zfm20;
using Encoder = System.Drawing.Imaging.Encoder;

namespace ProgramForArrest
{
    public partial class HomeForm : Form
    {
        // string data;
        string card;
        string password;
        string imagesStr;
        string org;
        string base64String;
        string base64StringInfo;
        string base64StringUser;
        string Fingerbase64String;
        string role;
        int updateAddPerson;
        string organization;
        HomeForm homeForm;
        AddPersonForm addper;

        // Default COM port settings. 
        private const string DefaultComPort = "COM5";
        private const int DefaultBaudRate = 115200;

        // Size of the fingerprint image. 
        private const int ImageWidth = 256;
        private const int ImageHeight = 288;

        private Zfm20Fingerprint _zfmSensor;


        public HomeForm(string card, string password, string org, string role, string organization)
        {
            InitializeComponent();
            this.card = card;
            this.password = password;
            this.org = org;
            this.role = role;
            this.organization = organization;
            Console.WriteLine(updateAddPerson);

        }

        public HomeForm(HomeForm homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;

        }

        public HomeForm(string card, string password, string org, string role, int updateAddPerson)
        {
            InitializeComponent();
            this.card = card;
            this.password = password;
            this.org = org;
            this.role = role;
            this.updateAddPerson = updateAddPerson;
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            Visible = false;
        }

        private void btComfirm_Click(object sender, EventArgs e)
        {

            if (tbPassword.Text == this.password)
            {

                if (tbNewPassword.Text == tbConfirm.Text)
                {

                    updatePassword input = new updatePassword();
                    RestClient client = new RestClient("http://202.28.34.197:8800");
                    RestRequest request = new RestRequest("/ArrestSystem/password/" + this.card);
                    input.password = tbNewPassword.Text;

                    var serializer = new JavaScriptSerializer();
                    string jsonStr = serializer.Serialize(input);
                    request.AddJsonBody(jsonStr);
                    var resuly = client.Execute<UpdatePasswordResult>(request, Method.POST);

                    //Console.WriteLine(resuly);

                    MessageBox.Show("เปลี่ยนรหัสผ่านสำเร็จ! ");
                }
                else{MessageBox.Show("รหัสผ่านไม่ตรงกัน");}
            }
            else{ MessageBox.Show("ไม่ถูกต้อง! กรุณาตรวจสอบใหม่อีกครั้ง");}
        }

        private void btConfirmUpdate_Click(object sender, EventArgs e)
        {
            String dateTH = tbUserBirthday.Value.ToString("yyyy-MM-dd");
            String[] words = dateTH.Split('-');
            String date1 = int.Parse(words[0]) - 543 + "-" + words[1] + "-" + words[2];
            //MessageBox.Show(date1);

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateUser input = new UpdateUser();
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/updateuser/" + this.card);


                input.title = tbTitle.Text;
                input.firstname = tbFirstname.Text;
                input.lastname = tbLastname.Text;
                input.card = tbCard.Text;
                input.date = date1;
                input.position = tbPosition.Text;
                input.organization = tbOrganization.Text;
                input.email = tbEmail.Text;
                input.phone = tbPhone.Text;
                input.address = tbAddress.Text;
                
                if (base64StringInfo == null)
                {
                    //imagesStr = base64StringInfo;
                    input.image_url = imagesStr;
                    Console.WriteLine("Image");
                }
                else
                {
                    input.image_url = base64StringInfo;
                    Console.WriteLine("New Image");
                }

                var serializer = new JavaScriptSerializer();
                string jsonStr = serializer.Serialize(input);
                request.AddJsonBody(jsonStr);
                var update = client.Execute<UpdateUserResult>(request, Method.POST);

                //Console.WriteLine(update);
                MessageBox.Show("เปลี่ยนข้อมูลสำเร็จ! ");


            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public void loadUsers()
        {
            try
            {

                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                RestRequest Getrequest = new RestRequest("/ArrestSystem/users/" + this.organization);
                var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);

                int i = 0;

                if (getUser.Data != null)
                {
                    while (i <= getUser.Data.Count)
                    {
                        string[] users = new string[]
                        {
                            getUser.Data[i].card.ToString(),
                            getUser.Data[i].title,
                            getUser.Data[i].firstname,
                            getUser.Data[i].lastname

                        };
                        listView_Users.Items.Add(new ListViewItem(users));
                        i++;
                    }
                }
            }
            catch { }
        }


        private void Home_Load(object sender, EventArgs e)
        {
            
            if (!this.role.Equals("ผู้ดูแลระบบ"))
            {
                tabControl1.TabPages.Remove(tabHome);
                tabControl1.TabPages.Remove(tabPage3);
            }

            _zfmSensor = new Zfm20Fingerprint(DefaultComPort, DefaultBaudRate);
            //////UPDATE INFO/////////
            try
            {

                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/search/user/card/" + this.card);
                var info = client.Execute<GetUserbyCard>(request, Method.GET);
                //this.tbBirthday.Enabled = false;
                if (info.Data != null) { 

                tbTitle.Text = info.Data.title;
                tbFirstname.Text = info.Data.firstname;
                tbLastname.Text = info.Data.lastname;
                tbCard.Text = info.Data.card.ToString();
                tbPosition.Text = info.Data.position;
                tbOrganization.Text = info.Data.organization;
                tbEmail.Text = info.Data.email;
                tbPhone.Text = info.Data.phone.ToString();
                tbAddress.Text = info.Data.address;

                var pic = Convert.FromBase64String(info.Data.image_url);
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    pictureBox_Info.Image = Image.FromStream(ms);
                }

                imagesStr = info.Data.image_url;
                //pictureBox_User.Image = (Image)(info.Data.image_url.);
                DateTime bdate = UnixTimeStampToDateTime((info.Data.birthday.value / 1000));
                tbBirthday.Value = bdate.Subtract(new TimeSpan(7, 0, 0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            loadUsers();


            try
            {
                getUserfoSeacrh();


            }
            catch { }

            //////////////
            try
            {
                getPersonforSearch();

            }
            catch { }

            try
            {
                getPersons();
            }
            catch { }
        }

        public void getUserfoSeacrh()
        {
            listView2.Items.Clear();
            RestClient Getclient = new RestClient("http://202.28.34.197:8800");
            RestRequest Getrequest = new RestRequest("/ArrestSystem/users/" + this.organization);
            var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);

            int i = 0;

            if (getUser.Data != null)
            {
                while (i < getUser.Data.Count)
                {
                    string[] users = new string[]
                    {
                            getUser.Data[i].card.ToString(),
                            getUser.Data[i].title,
                            getUser.Data[i].firstname,
                            getUser.Data[i].lastname,
                            getUser.Data[i].position,
                            getUser.Data[i].phone
                    };
                    listView2.Items.Add(new ListViewItem(users));
                    i++;
                }
            }
        }

        public void getPersons()
        {
            RestClient client = new RestClient("http://202.28.34.197:8800");
            RestRequest request = new RestRequest("/ArrestSystem/persons/org/" + this.organization);
            var getPerson = client.Execute<List<GetAllPerson_data>>(request, Method.GET);
            
            int i = 0;

            while (i <= getPerson.Data.Count)
            {
                string[] Persons = new string[]
                {
                            getPerson.Data[i].card.ToString(),
                            getPerson.Data[i].firstname,
                            getPerson.Data[i].lastname,
                            getPerson.Data[i].group,
                            getPerson.Data[i].address
                };
                listView_Persons.Items.Add(new ListViewItem(Persons));
                i++;
            }
        }

        public void getPersonforSearch()
        {
            listView1.Items.Clear();
            RestClient client = new RestClient("http://202.28.34.197:8800");
            RestRequest request = new RestRequest("/ArrestSystem/persons/org/"+this.organization);
            var getPerson = client.Execute<List<GetAllPerson_data>>(request, Method.GET);

            int i = 0;

            while (i <= getPerson.Data.Count)
            {
                string[] Persons = new string[]
                {
                            getPerson.Data[i].card.ToString(),
                            getPerson.Data[i].firstname,
                            getPerson.Data[i].lastname,
                            getPerson.Data[i].group,
                            getPerson.Data[i].address
                };
                listView1.Items.Add(new ListViewItem(Persons));
                i++;
            }
        }

        public void getInfo()
        {
            try
            {

                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/search/user/card/" + this.card);
                var info = client.Execute<GetUserbyCard>(request, Method.GET);

                tbTitle.Text = info.Data.title;
                tbFirstname.Text = info.Data.firstname;
                tbLastname.Text = info.Data.lastname;
                tbCard.Text = info.Data.card.ToString();
                tbPosition.Text = info.Data.position;
                tbOrganization.Text = info.Data.organization;
                tbEmail.Text = info.Data.email;
                tbPhone.Text = info.Data.phone.ToString();
                tbAddress.Text = info.Data.address;

                var pic = Convert.FromBase64String(info.Data.image_url);
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    pictureBox_Info.Image = Image.FromStream(ms);
                }
                imagesStr = info.Data.image_url;
                

                DateTime bdate = UnixTimeStampToDateTime(info.Data.birthday.value / 1000);
                tbBirthday.Value = bdate.Subtract(new TimeSpan(7, 0, 0));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public byte[] ImagetoByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }


        private void listView_Persons_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectCard = listView_Persons.SelectedItems[0].SubItems[0].Text;

                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                RestRequest Getrequest = new RestRequest("/ArrestSystem/persons/" + selectCard);
                var getPersons = Getclient.Execute<List<SearchPersons_data>>(Getrequest, Method.GET);
                int i = 0;


                while (i <= getPersons.Data.Count)
                {

                    if (listView_Persons.SelectedItems[0].SubItems[0].Text != null)
                    {
                        tbPersonTitle.Text = getPersons.Data[0].title;
                        tbPersonCard.Text = getPersons.Data[0].card;
                        tbPersonFirstName.Text = getPersons.Data[0].firstname;
                        tbPersonLastName.Text = getPersons.Data[0].lastname;
                        DateTime bdate = UnixTimeStampToDateTime(getPersons.Data[0].birthday.value / 1000);
                        tbPersonBirthday.Value = bdate.Subtract(new TimeSpan(7, 0, 0));
                        tbPersonPhone.Text = getPersons.Data[0].phone;
                        tbPersonGroup.Text = getPersons.Data[0].group;
                        tbPersonAddress.Text = getPersons.Data[0].address;
                        
                        var pic = Convert.FromBase64String(getPersons.Data[0].image_url);
                        using (MemoryStream ms = new MemoryStream(pic))
                        {
                            pictureBox_Person.Image = Image.FromStream(ms);
                        }
                        imagesStr = getPersons.Data[0].image_url;
                        //Console.WriteLine(imagesStr);
                    }
                    i++;
                }
            }
            catch { }

        }



        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox_Pass_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            Visible = false;
        }

        private void listView_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectCard = listView_Users.SelectedItems[0].SubItems[0].Text;


                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/search/user/card/" + selectCard);
                var getUsers = client.Execute<GetUserbyCard>(request, Method.GET);

                //Console.WriteLine(tbUserCard.Text);
                if (listView_Users.SelectedItems[0].SubItems[0].Text != null)
                {

                    tbUserTitle.Text = getUsers.Data.title;
                    tbUserCard.Text = getUsers.Data.card;
                    tbUserFristname.Text = getUsers.Data.firstname;
                    tbUserLastname.Text = getUsers.Data.lastname;

                    DateTime bdate = UnixTimeStampToDateTime(getUsers.Data.birthday.value / 1000);
                    tbUserBirthday.Value = bdate.Subtract(new TimeSpan(7, 0, 0));

                    tbUserOrganization.Text = getUsers.Data.organization;
                    tbUserPosition.Text = getUsers.Data.position;
                    tbUserEmail.Text = getUsers.Data.email;
                    tbUserPhone.Text = getUsers.Data.phone;
                    tbUserAddress.Text = getUsers.Data.address;

                    var pic = Convert.FromBase64String(getUsers.Data.image_url);
                    using (MemoryStream ms = new MemoryStream(pic))
                    {
                        pictureBox_User.Image = Image.FromStream(ms);
                    }
                }

            }
            catch { }


        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Clear();
            tbPassword.PasswordChar = '●';

        }

        private void tbNewPassword_Click(object sender, EventArgs e)
        {
            tbNewPassword.Clear();
            tbNewPassword.PasswordChar = '●';
        }

        private void tbConfirm_Click(object sender, EventArgs e)
        {
            tbConfirm.Clear();
            tbConfirm.PasswordChar = '●';

        }




        private void btImageInfo_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Info.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Info.Image = Image.FromFile(openFileDialog_Info.FileName);
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog_Info.FileName);
                base64StringInfo = Convert.ToBase64String(imageArray);
            }
        }

        private void btPersonImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Person.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Person.Image = Image.FromFile(openFileDialog_Person.FileName);
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog_Person.FileName);
                base64String = Convert.ToBase64String(imageArray);

            }
        }

        public void refeshUser()
        {
            listView_Users.Items.Clear();
            RestClient Getclient = new RestClient("http://202.28.34.197:8800");
            RestRequest Getrequest = new RestRequest("/ArrestSystem/users/"+this.organization);
            var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);

            int i = 0;

                while (i < getUser.Data.Count)
                {
                    string[] users = new string[]
                    {
                            getUser.Data[i].card.ToString(),
                            getUser.Data[i].title,
                            getUser.Data[i].firstname,
                            getUser.Data[i].lastname,
                            getUser.Data[i].organization,
                            
                    };
                    listView_Users.Items.Add(new ListViewItem(users));

                    i++;
                }
        }


        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            String dateTH = tbUserBirthday.Value.ToString("yyyy-MM-dd");
            String[] words = dateTH.Split('-');
            String date1 = int.Parse(words[0]) - 543 + "-" + words[1] + "-" + words[2];

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UpdateUserbyAdmin input = new UpdateUserbyAdmin();
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/updateuser/" + tbUserCard.Text);
                input.admincard = this.card;
                input.title = tbUserTitle.Text;
                input.firstname = tbUserFristname.Text;
                input.lastname = tbUserLastname.Text;
                input.card = tbUserCard.Text;
                input.date = date1;
                input.position = tbUserPosition.Text;
                input.organization = tbUserOrganization.Text;
                input.email = tbUserEmail.Text;
                input.phone = tbUserPhone.Text;
                input.address = tbUserAddress.Text;

                if (base64StringUser == null)
                {
                    imagesStr = base64StringUser;
                    input.image_url = imagesStr;
                    //Console.WriteLine("Image");

                }
                else
                {
                    input.image_url = base64StringUser;
                    //Console.WriteLine("New Image");


                }

                var serializer = new JavaScriptSerializer();
                string jsonStr = serializer.Serialize(input);
                request.AddJsonBody(jsonStr);
                var update = client.Execute<UdateUserbyAdmin_Result>(request, Method.POST);


                //Console.WriteLine(update);

                MessageBox.Show("บันทึกข้อมูลสำเร็จ!");
                
                refeshUser();
                getUserfoSeacrh();
            }

            
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {

            AddUserForm addUserForm = new AddUserForm(this,this.card, this.organization);
            addUserForm.Visible = true;
        }

        public void refeshPerson(){

            listView_Persons.Items.Clear();
            RestClient client = new RestClient("http://202.28.34.197:8800");
            RestRequest request = new RestRequest("/ArrestSystem/persons/org/"+this.organization);
            var getPerson = client.Execute<List<GetAllPerson_data>>(request, Method.GET);

            int i = 0;

            while (i < getPerson.Data.Count)
            {
                string[] Persons = new string[]
                {
                            getPerson.Data[i].card.ToString(),
                            getPerson.Data[i].firstname,
                            getPerson.Data[i].lastname,
                            getPerson.Data[i].group
                };
                listView_Persons.Items.Add(new ListViewItem(Persons));
                i++;
            }
            
        }

        private void btUpdatePersons_Click(object sender, EventArgs e)
        {

            try
            {
                String dateTH = tbPersonBirthday.Value.ToString("yyyy-MM-dd");
                String[] words = dateTH.Split('-');
                String date1 = int.Parse(words[0]) - 543 + "-" + words[1] + "-" + words[2];
                //MessageBox.Show(date1);


                if (MessageBox.Show("ยืนยันการแก้ไขข้อมูลบุคคล", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UpdatePersons input = new UpdatePersons();
                    RestClient client = new RestClient("http://202.28.34.197:8800");
                    RestRequest request = new RestRequest("/ArrestSystem/personupdate/" + tbPersonCard.Text);


                    UpdatePersons_Result data = new UpdatePersons_Result();

                    input.admincard = this.card;
                    input.title = tbPersonTitle.Text;
                    input.firstname = tbPersonFirstName.Text;
                    input.lastname = tbPersonLastName.Text;
                    input.card = tbPersonCard.Text;
                    input.date = date1;
                    input.phone = tbPersonPhone.Text;
                    input.address = tbPersonAddress.Text;
                    input.group = tbPersonGroup.Text;
                    input.image_url = base64String;

                    if (base64String == null)
                    {
                        //imagesStr = base64String;
                        input.image_url = imagesStr;
                        //Console.WriteLine("Image");

                    }
                    else
                    {
                        input.image_url = base64String;
                        //Console.WriteLine("New Image");


                    }

                    var serializer = new JavaScriptSerializer();
                    string jsonStr = serializer.Serialize(input);
                    request.AddJsonBody(jsonStr);
                    var updatePerson = client.Execute<UpdatePersons_Result>(request, Method.POST);


                    //Console.WriteLine(updatePerson);

                    MessageBox.Show("แก้ไขข้อมูลบุคคลสำเร็จ! ");
                    

                    refeshPerson();
                    getPersonforSearch();
                }
            }
            catch { }
        }


        private void btAddPerson_Click(object sender, EventArgs e)
        {
            AddPersonForm AddPersonForm = new AddPersonForm(this.card, this, this.organization);
            AddPersonForm.Visible = true;
        }

        private void btAddFingerPrint_Click(object sender, EventArgs e)
        {

            //String idAdmin = getID.Data[0].id;
            //Console.WriteLine(getID.Data[0].id);



            AddFingerprintForm addFingerprint = new AddFingerprintForm(this.card, this.org);
            addFingerprint.Visible = true;


        }

        public void SaveJpeg(Image img, string filename, int quality)
        {
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, (long)quality);
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(filename, jpegCodec, encoderParams);
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            var encoders = ImageCodecInfo.GetImageEncoders();
            var encoder = encoders.SingleOrDefault(c => string.Equals(c.MimeType, mimeType, StringComparison.InvariantCultureIgnoreCase));
            if (encoder == null) throw new Exception($"Encoder not found for mime type {mimeType}");
            return encoder;
        }
        public byte[] ImageToByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }


        public Image ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream(blob);
            //byte[] pData = blob;
            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //Bitmap bm = new Bitmap(mStream, false);
            //mStream.Dispose();
            return Image.FromStream(mStream);
        }



        private string ZfmStatusToString(Zfm20Fingerprint.ZfmStatus inStatus)
        {
            switch (inStatus)
            {
                case Zfm20Fingerprint.ZfmStatus.ZsUnknownError:
                    return @"Unknown error has occurred.";
                case Zfm20Fingerprint.ZfmStatus.ZsTimeout:
                    return @"Communication timeout with sensor.";
                case Zfm20Fingerprint.ZfmStatus.ZsNoFinger:
                    return @"Finger is not available.";
                case Zfm20Fingerprint.ZfmStatus.ZsFingerCollectError:
                    return @"Finger collection error.";
                case Zfm20Fingerprint.ZfmStatus.ZsBadResponse:
                    return @"Communication failure with sensor.";
                case Zfm20Fingerprint.ZfmStatus.ZsDataError:
                    return @"Data format error.";
                case Zfm20Fingerprint.ZfmStatus.ZsIoError:
                    return @"Data I/O error occurred.";
                case Zfm20Fingerprint.ZfmStatus.ZsMemoryError:
                    return @"Memory error has been occurred.";
                default:
                    return string.Empty;
            }
        }

        private void btUserImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog_User.ShowDialog() == DialogResult.OK)
            {
                pictureBox_User.Image = Image.FromFile(openFileDialog_User.FileName);
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog_User.FileName);
                base64StringUser = Convert.ToBase64String(imageArray);

            }
        }

        private void btInfoImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Info.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Info.Image = Image.FromFile(openFileDialog_Info.FileName);
                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog_Info.FileName);
                base64StringInfo = Convert.ToBase64String(imageArray);

            }
        }



        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try 
            { 
                if (e.KeyCode == Keys.F1) {}
                else
                {
                    if (!tbSearch.Text.Equals(""))
                    {

                        RestClient client = new RestClient("http://202.28.34.197:8800");
                        RestRequest request = new RestRequest("/ArrestSystem/search/user/" + tbSearch.Text);
                        var getUsers = client.Execute<List<SearchUsers_Data>>(request, Method.GET);
                        listView2.Items.Clear();

                        int i = 0;

                        if (!getUsers.Content.Equals("")) {
                            while (i <= getUsers.Data.Count)
                            {
                                string[] users = new string[]
                                {
                                getUsers.Data[i].card.ToString(),
                                getUsers.Data[i].title,
                                getUsers.Data[i].firstname,
                                getUsers.Data[i].lastname,
                                getUsers.Data[i].position,
                                getUsers.Data[i].phone
                                };

                                listView2.Items.Add(new ListViewItem(users));
                                i++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูล");
                            try
                            {

                                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                                RestRequest Getrequest = new RestRequest("/ArrestSystem/users");
                                var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);
                                listView2.Items.Clear();
                                

                                while (i <= getUser.Data.Count)
                                {
                                    string[] users = new string[]
                                    {
                                    getUser.Data[i].card.ToString(),
                                    getUser.Data[i].title,
                                    getUser.Data[i].firstname,
                                    getUser.Data[i].lastname,
                                    getUser.Data[i].position,
                                    getUser.Data[i].phone
                                    };
                                    //listView_Users.Items.Add(new ListViewItem(users));
                                    listView2.Items.Add(new ListViewItem(users));
                                    i++;
                                }
                            }
                            catch { }
                        }
                    }
                    
                    else
                    {
                        listView2.Items.Clear();
                        try
                        {

                            RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                            RestRequest Getrequest = new RestRequest("/ArrestSystem/users");
                            var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);
                            listView2.Items.Clear();
                            int i = 0;

                            while (i <= getUser.Data.Count)
                            {
                                string[] users = new string[]
                                {
                                    getUser.Data[i].card.ToString(),
                                    getUser.Data[i].title,
                                    getUser.Data[i].firstname,
                                    getUser.Data[i].lastname,
                                    getUser.Data[i].position,
                                    getUser.Data[i].phone
                                };
                                //listView_Users.Items.Add(new ListViewItem(users));
                                listView2.Items.Add(new ListViewItem(users));
                                i++;
                            }
                        }
                        catch { }

                    }
                }
            }
            catch { }
        }

        private void tbSearchPersons_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1) { }
                else
                {
                    if (!tbSearchPersons.Text.Equals(""))
                    {

                        RestClient client = new RestClient("http://202.28.34.197:8800");
                        RestRequest request = new RestRequest("/ArrestSystem/search/" + tbSearchPersons.Text);
                        var getPersons = client.Execute<List<SearchPersons_data>>(request, Method.GET);


                        int i = 0;
                        listView_Persons.Items.Clear();
                        if (!getPersons.Content.Equals("[]"))
                        {
                            while (i <= getPersons.Data.Count)
                            {
                                string[] persons = new string[]
                                {
                                    getPersons.Data[i].card.ToString(),
                                    getPersons.Data[i].firstname,
                                    getPersons.Data[i].lastname,
                                    getPersons.Data[i].group,
                                    getPersons.Data[i].address
                                };

                                listView_Persons.Items.Add(new ListViewItem(persons));
                                i++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูล");

                            try
                            {
                                RestClient getClient = new RestClient("http://202.28.34.197:8800");
                                RestRequest getRequest = new RestRequest("/ArrestSystem/persons");
                                var getPerson = getClient.Execute<List<GetAllPerson_data>>(getRequest, Method.GET);
                                listView_Persons.Items.Clear();
                                
                                while (i <= getPersons.Data.Count)
                                {
                                    string[] persons = new string[]
                                    {
                                    getPersons.Data[i].card.ToString(),
                                    getPersons.Data[i].firstname,
                                    getPersons.Data[i].lastname,
                                    getPersons.Data[i].group,
                                    getPersons.Data[i].address
                                    };

                                    listView_Persons.Items.Add(new ListViewItem(persons));
                                    i++;
                                }
                            }
                            catch { }
                        }
                        

                    }
                    else
                    {
                        listView_Persons.Items.Clear();
                        try
                        {
                            RestClient client = new RestClient("http://202.28.34.197:8800");
                            RestRequest request = new RestRequest("/ArrestSystem/persons");
                            var getPersons = client.Execute<List<GetAllPerson_data>>(request, Method.GET);
                            listView_Persons.Items.Clear();
                            int i = 0;
                            while (i <= getPersons.Data.Count)
                            {
                                string[] persons = new string[]
                                {
                                    getPersons.Data[i].card.ToString(),
                                    getPersons.Data[i].firstname,
                                    getPersons.Data[i].lastname,
                                    getPersons.Data[i].group,
                                    getPersons.Data[i].address
                                };

                                listView_Persons.Items.Add(new ListViewItem(persons));
                                i++;
                            }
                        }
                        catch { }

                    }
                }
            }
            catch { }
        }

        

        private void tbSearchPerson_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1) { }
                else
                {
                    if (!tbSearchPerson.Text.Equals(""))
                    {

                        RestClient client = new RestClient("http://202.28.34.197:8800");
                        RestRequest request = new RestRequest("/ArrestSystem/search/" + tbSearchPerson.Text);
                        var getPersons = client.Execute<List<SearchPersons_data>>(request, Method.GET);


                        int i = 0;
                        listView_Persons.Items.Clear();
                        if (!getPersons.Content.Equals("[]"))
                        {
                            while (i <= getPersons.Data.Count)
                            {
                                string[] persons = new string[]
                                {
                                    getPersons.Data[i].card.ToString(),
                                    getPersons.Data[i].firstname,
                                    getPersons.Data[i].lastname,
                                    getPersons.Data[i].group,
                                    getPersons.Data[i].address
                                };

                                listView_Persons.Items.Add(new ListViewItem(persons));
                                i++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูล");

                            try
                            {
                                RestClient getClient = new RestClient("http://202.28.34.197:8800");
                                RestRequest getRequest = new RestRequest("/ArrestSystem/persons");
                                var getPerson = getClient.Execute<List<GetAllPerson_data>>(getRequest, Method.GET);
                                listView_Persons.Items.Clear();

                                while (i <= getPersons.Data.Count)
                                {
                                    string[] persons = new string[]
                                    {
                                        getPersons.Data[i].card.ToString(),
                                        getPersons.Data[i].firstname,
                                        getPersons.Data[i].lastname,
                                        getPersons.Data[i].group,
                                        getPersons.Data[i].address
                                    };

                                    listView_Persons.Items.Add(new ListViewItem(persons));
                                    i++;
                                }
                            }
                            catch { }
                        }


                    }
                    else
                    {
                        listView_Persons.Items.Clear();
                        try
                        {
                            RestClient client = new RestClient("http://202.28.34.197:8800");
                            RestRequest request = new RestRequest("/ArrestSystem/persons");
                            var getPersons = client.Execute<List<GetAllPerson_data>>(request, Method.GET);
                            listView_Persons.Items.Clear();
                            int i = 0;
                            while (i <= getPersons.Data.Count)
                            {
                                string[] persons = new string[]
                                {
                                    getPersons.Data[i].card.ToString(),
                                    getPersons.Data[i].firstname,
                                    getPersons.Data[i].lastname,
                                    getPersons.Data[i].group,
                                    getPersons.Data[i].address
                                };

                                listView_Persons.Items.Add(new ListViewItem(persons));
                                i++;
                            }
                        }
                        catch { }

                    }
                }
            }
            catch { }
        }

        private void tbSeachUser_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1) { }
                else
                {
                    if (!tbSeachUser.Text.Equals(""))
                    {

                        RestClient client = new RestClient("http://202.28.34.197:8800");
                        RestRequest request = new RestRequest("/ArrestSystem/search/user/" + tbSeachUser.Text);
                        var getUsers = client.Execute<List<SearchUsers_Data>>(request, Method.GET);
                        listView_Users.Items.Clear();

                        int i = 0;

                        if (!getUsers.Content.Equals(""))
                        {
                            while (i <= getUsers.Data.Count)
                            {
                                string[] users = new string[]
                                {
                                getUsers.Data[i].card.ToString(),
                                getUsers.Data[i].title,
                                getUsers.Data[i].firstname,
                                getUsers.Data[i].lastname,
                                getUsers.Data[i].position,
                                getUsers.Data[i].phone
                                };

                                listView_Users.Items.Add(new ListViewItem(users));
                                i++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูล");
                            try
                            {

                                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                                RestRequest Getrequest = new RestRequest("/ArrestSystem/users");
                                var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);
                                listView_Users.Items.Clear();


                                while (i <= getUser.Data.Count)
                                {
                                    string[] users = new string[]
                                    {
                                    getUser.Data[i].card.ToString(),
                                    getUser.Data[i].title,
                                    getUser.Data[i].firstname,
                                    getUser.Data[i].lastname,
                                    getUser.Data[i].position,
                                    getUser.Data[i].phone
                                    };
                                    //listView_Users.Items.Add(new ListViewItem(users));
                                    listView_Users.Items.Add(new ListViewItem(users));
                                    i++;
                                }
                            }
                            catch { }
                        }
                    }

                    else
                    {
                        listView_Users.Items.Clear();
                        try
                        {

                            RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                            RestRequest Getrequest = new RestRequest("/ArrestSystem/users");
                            var getUser = Getclient.Execute<List<GetAllUser_data>>(Getrequest, Method.GET);
                            listView_Users.Items.Clear();
                            int i = 0;

                            while (i <= getUser.Data.Count)
                            {
                                string[] users = new string[]
                                {
                                    getUser.Data[i].card.ToString(),
                                    getUser.Data[i].title,
                                    getUser.Data[i].firstname,
                                    getUser.Data[i].lastname,
                                    getUser.Data[i].position,
                                    getUser.Data[i].phone
                                };
                                //listView_Users.Items.Add(new ListViewItem(users));
                                listView_Users.Items.Add(new ListViewItem(users));
                                i++;
                            }
                        }
                        catch { }

                    }
                }
            }
            catch { }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            try
            {

                string msgText = _zfmSensor.IsAvailable() ? @"Fingerprint sensor is available." : "Fingerprint sensor is not available.\nCheck sensor configuration options.";
                //MessageBox.Show(msgText, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Zfm20Fingerprint.ZfmStatus captureStatus = _zfmSensor.Capture();
                if (captureStatus != Zfm20Fingerprint.ZfmStatus.ZsSuccessful)
                {

                    MessageBox.Show("กรุณาวางนิ้วมือก่อนสแกน", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    IntPtr dataBuffer;
                    uint dataBufferSize;

                    Zfm20Fingerprint.ZfmStatus downloadStatus = _zfmSensor.GetFingerprintBuffer(out dataBuffer, out dataBufferSize);
                    if (downloadStatus == Zfm20Fingerprint.ZfmStatus.ZsSuccessful)
                    {
                        if (dataBufferSize > 0)
                        {
                            // Create output bitmap buffer object. 
                            Bitmap outputImage = new Bitmap(ImageWidth, ImageHeight);
                            byte[] colorBuffer = new byte[dataBufferSize];
                            int bufferPos = 0;

                            Marshal.Copy(dataBuffer, colorBuffer, 0, (int)(dataBufferSize - 1));
                            int count = 0;
                            // Paint bitmap buffer with received data buffer content.
                            for (int yPos = 0; yPos < ImageHeight; yPos++)
                            {
                                for (int xPos = 0; xPos < ImageWidth; xPos++)
                                {
                                    count++;
                                    outputImage.SetPixel(xPos, yPos, Color.FromArgb(colorBuffer[bufferPos], colorBuffer[bufferPos], colorBuffer[bufferPos]));
                                    bufferPos++;
                                    if(count % 737 == 0)
                                    {
                                        progressBar1.Value += 1;
                                    }
                                }
                            }

                            // Flush data buffer and show bitmap on UI.
                            _zfmSensor.FreeFingerprintBuffer(ref dataBuffer);
                            Bitmap bmp = new Bitmap(outputImage);
                            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);

                            pictureBox_Finger.Image = bmp;

                            byte[] gg = Relm.Converters.Converter.ToByteArray(pictureBox_Finger.Image);
                            Fingerbase64String = Convert.ToBase64String(gg);

                            //Console.WriteLine(Fingerbase64String);


                            try
                            {

                                    MatchingFinger input = new MatchingFinger();
                                    RestClient client = new RestClient("http://202.28.34.197:8800");
                                    RestRequest request = new RestRequest("/fingerprintSystem/template/matching/" + this.org);
                                    int i=0;
                                    input.template = Fingerbase64String;

                                    var serializer = new JavaScriptSerializer();
                                    string jsonStr = serializer.Serialize(input);
                                    request.AddJsonBody(jsonStr);
                                    var fingerprint = client.Execute<List<MatchingFinger_ResultData>>(request, Method.POST);
                                    progressBar1.Visible = true;



                                    if (fingerprint.Data.Count > i)
                                    {
                                        if (radioFigLeft.Checked) 
                                        {
                                            SearchbyFidLeft FidLeft = new SearchbyFidLeft();
                                            RestRequest FidLeftRequest = new RestRequest("/ArrestSystem/person/fleft/search");
                                            
                                            FidLeft.fid = fingerprint.Data[0].key;

                                            var serializerFL = new JavaScriptSerializer();
                                            string jsonStrFL = serializer.Serialize(FidLeft);
                                            FidLeftRequest.AddJsonBody(jsonStrFL);
                                            var FidLeftfingerprint = client.Execute<List<SearchbyFidLeft_ResultData>>(FidLeftRequest, Method.POST);
                                            
                                            //MessageBox.Show(FidLeftfingerprint.Data[0].firstname);
                                            btProof.Visible = true;

                                        while (i <= FidLeftfingerprint.Data.Count)
                                            {

                                                string[] fings = new string[]
                                                {
                                                    FidLeftfingerprint.Data[i].card,
                                                    FidLeftfingerprint.Data[i].firstname,
                                                    FidLeftfingerprint.Data[i].lastname,
                                                    FidLeftfingerprint.Data[i].group
                                                };

                                                listView_Matching.Items.Add(new ListViewItem(fings));
                                                i++;
                                                
                                            }
                                        progressBar1.Visible = false;


                                        }
                                    
                                        else if (radioFigRight.Checked) 
                                        {
                                            SearchbyFidLeft FidRight = new SearchbyFidLeft();
                                            RestRequest FidRightRequest = new RestRequest("/ArrestSystem/person/fright/search");
                                            
                                            FidRight.fid = fingerprint.Data[0].key;

                                            var serializerFR = new JavaScriptSerializer();
                                            string jsonStrFR = serializer.Serialize(FidRight);
                                            FidRightRequest.AddJsonBody(jsonStrFR);
                                            var FidRightfingerprint = client.Execute<List<SearchbyFidRight_ResultData>>(FidRightRequest, Method.POST);
                                            btProof.Visible = true;

                                            while (i <= FidRightfingerprint.Data.Count)
                                            {

                                                string[] fings = new string[]
                                                {
                                                        FidRightfingerprint.Data[i].card,
                                                        FidRightfingerprint.Data[i].firstname,
                                                        FidRightfingerprint.Data[i].lastname,
                                                        FidRightfingerprint.Data[i].group
                                                };

                                                listView_Matching.Items.Add(new ListViewItem(fings));
                                                i++;
                                            }

                                            progressBar1.Visible = false;
                                        }
                                    
                                        else
                                        {
                                            MessageBox.Show("กรุณาเลือกลักษณะลายนิ้วมือ");
                                        }

                                    }
                                
                                    else 
                                    {
                                        MessageBox.Show("ไม่พบข้อมูล");
                                        progressBar1.Visible = false;
                                    }
                            }
                            catch { }


                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView_Matching_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectCard = listView_Matching.SelectedItems[0].SubItems[0].Text;

                RestClient Getclient = new RestClient("http://202.28.34.197:8800");
                RestRequest Getrequest = new RestRequest("/ArrestSystem/persons/" + selectCard);
                var getPersons = Getclient.Execute<List<SearchPersons_data>>(Getrequest, Method.GET);
                int i = 0;


                while (i <= getPersons.Data.Count)
                {

                    if (listView_Matching.SelectedItems[0].SubItems[0].Text != null)
                    {
                        
                        tbMCard.Text = getPersons.Data[0].card;
                        tbMFirstName.Text = getPersons.Data[0].firstname;
                        tbMLastname.Text = getPersons.Data[0].lastname;
                        tbMGroup.Text = getPersons.Data[0].group;
                        tbMPhone.Text = getPersons.Data[0].address;
                        var pic = Convert.FromBase64String(getPersons.Data[0].image_url);
                        using (MemoryStream ms = new MemoryStream(pic))
                        {
                            pictureBox_Finger.Image = Image.FromStream(ms);
                        }
                        imagesStr = getPersons.Data[0].image_url;
                        //Console.WriteLine(imagesStr);
                    }
                    i++;
                }
            }
            catch { }
        }

        private void btProof_Click(object sender, EventArgs e)
        {
           

            ProofForm proof = new ProofForm(tbMCard.Text);
            proof.Visible = true;

            
        }

    }
 }
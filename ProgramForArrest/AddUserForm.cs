using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ThaiNationalIDCard;

namespace ProgramForArrest
{
    public partial class AddUserForm : Form
    {
        string card;
        string base64String;
        HomeForm h;
        public AddUserForm(HomeForm h, string card)
        {
            InitializeComponent();
            this.card = card;
            this.h = h;
        }


        private void btAddUser_Click(object sender, EventArgs e)
        {
           
            try
            {
                String dateTH = tbUserBirthday.Value.ToString("yyyy-MM-dd");
                String[] words = dateTH.Split('-');
                String date1 = int.Parse(words[0]) - 543 + "-" + words[1] + "-" + words[2];
                //MessageBox.Show(date1);


                if (MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK) { 
                AddUserbyAdmin input = new AddUserbyAdmin();
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/users");

                input.admincard = this.card;
                input.title = tbUserTitle.Text;
                input.firstname = tbUserFristname.Text;
                input.lastname = tbUserLastname.Text;
                input.card = tbUserCard.Text;
                input.date = date1;
                input.position = tbUserPosition.Text;
                //input.organization = tbUsersOrganization.Text;
                input.email = tbUserEmail.Text;
                input.phone = tbUserPhone.Text;
                input.address = tbUserAddress.Text;
                input.image_url = base64String;

                var serializer = new JavaScriptSerializer();
                string jsonStr = serializer.Serialize(input);
                request.AddJsonBody(jsonStr);
                var AddUser = client.Execute<AddUserbyAddmin_Result>(request, Method.POST);

                    //Console.WriteLine(AddUser);
                    if (AddUser.Content.Equals("หมายเลขบัตรประชาชนนี้มีคนใช้อยู่แล้ว กรุณาลองใหม่!!"))
                    {
                        MessageBox.Show("หมายเลขบัตรประชาชนนี้มีคนใช้อยู่แล้ว กรุณาลองใหม่");
                    }
                    else
                    {
                        MessageBox.Show("บันทึกข้อมูลสำเร็จ! ");
                    }
                
                }
            }
            catch { }
            this.h.refeshUser();
            this.h.getUserfoSeacrh();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readCard();
        }

        public void readCard()
        {
            ThaiIDCard idcard = new ThaiIDCard();
            Personal personal = idcard.readAllPhoto();

            if (personal != null)
            {

                tbUserFristname.Text = personal.Th_Firstname;
                tbUserLastname.Text = personal.Th_Lastname;
                tbUserTitle.Text = personal.Th_Prefix;
                tbUserCard.Text = personal.Citizenid;
                tbUserBirthday.Text = personal.Birthday.ToString("yyyy-MM-dd");
                tbUserAddress.Text = personal.Address;
                pictureBox_User.Image = ByteToImage1(personal.PhotoRaw);

                // Convert byte[] to Base64 String
                base64String = Convert.ToBase64String(personal.PhotoRaw);

                // Write the bytes (as a Base64 string) to the textbox
                //Console.WriteLine(base64String);

            }
            else if (idcard.ErrorCode() > 0)
            {
                Console.WriteLine(idcard.Error());
            }
        }
        public static Bitmap ByteToImage1(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public void SaveJpeg(Image img, string filename, int quality)
        {

            byte[] byteArray = ImageToByteArray(img);
            Image result = null;
            ImageFormat format = ImageFormat.Png;
            result = new Bitmap(new MemoryStream(byteArray));


            using (Image imageToExport = result)
            {
                string filePath = string.Format(filename, format.ToString());
                imageToExport.Save(filePath, format);
            }
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
            return Image.FromStream(mStream);
        }
    }
}

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
using Encoder = System.Drawing.Imaging.Encoder;

namespace ProgramForArrest
{
    public partial class AddPersonForm : Form
    {
        string card;
        string base64String;
        int updateAddPerson;
        string organization;
        HomeForm home;
        public AddPersonForm(string card, HomeForm home, string organization)
        {
            
            InitializeComponent();
            this.home = home;
            this.card = card;
            this.organization = organization;
        }

        
        private void btAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                String dateTH = tbPersonBirthday.Value.ToString("yyyy-MM-dd");
                String[] words = dateTH.Split('-');
                String date1 = int.Parse(words[0]) - 543 + "-" + words[1] + "-" + words[2];
                //MessageBox.Show(date1);

                if (!tbPersonTitle.Text.Equals("") && !tbPersonFirstname.Text.Equals("") &&
                    !tbPersonLastname.Text.Equals("") && !tbPersonCard.Text.Equals("") &&
                    !tbPersonPhone.Text.Equals("") && !tbPersonAddress.Text.Equals("") &&
                    !tbPersonGroup.Text.Equals("")) { 
                    if (MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        AddPersons input = new AddPersons();
                        RestClient client = new RestClient("http://202.28.34.197:8800");
                        RestRequest request = new RestRequest("/ArrestSystem/persons");
                        input.org = this.organization;
                        input.admincard = this.card;
                        input.title = tbPersonTitle.Text;
                        input.firstname = tbPersonFirstname.Text;
                        input.lastname = tbPersonLastname.Text;
                        input.card = tbPersonCard.Text;
                        input.date = date1;
                        input.phone = tbPersonPhone.Text;
                        input.address = tbPersonAddress.Text;
                        input.image_url = base64String;
                        input.group = tbPersonGroup.Text;
                    

                        var serializer = new JavaScriptSerializer();
                        string jsonStr = serializer.Serialize(input);
                        request.AddJsonBody(jsonStr);
                        var AddPerson = client.Execute<AddPerson_Result>(request, Method.POST);


                        MessageBox.Show("บันทึกข้อมูลสำเร็จ!");
                       
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วนก่อนบันทึก");
                }
            
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            home.refeshPerson();
            home.getPersonforSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                MessageBox.Show("กรุณาวางนิ้วมือก่อนสแกน", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            readCard();

        }
        public void readCard()
        {
            ThaiIDCard idcard = new ThaiIDCard();
            Personal personal = idcard.readAllPhoto();

            if (personal != null)
            {

                tbPersonFirstname.Text = personal.Th_Firstname;
                tbPersonLastname.Text = personal.Th_Lastname;
                tbPersonTitle.Text = personal.Th_Prefix;
                tbPersonCard.Text = personal.Citizenid;
                tbPersonBirthday.Text = personal.Birthday.ToString("yyyy-MM-dd");
                tbPersonAddress.Text = personal.Address;
                pictureBox_Person.Image = ByteToImage1(personal.PhotoRaw);

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

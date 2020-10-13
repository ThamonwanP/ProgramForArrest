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
        public AddPersonForm(string card)
        {
            
            InitializeComponent();
            this.card = card;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void btAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่", "Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    AddPersons input = new AddPersons();
                    RestClient client = new RestClient("http://202.28.34.197:8800");
                    RestRequest request = new RestRequest("/ArrestSystem/persons");

                    input.admincard = this.card;
                    input.title = tbPersonTitle.Text;
                    input.firstname = tbPersonFirstname.Text;
                    input.lastname = tbPersonLastname.Text;
                    input.card = tbPersonCard.Text;
                    input.date = tbPersonBirthday.Value.ToString("yyyy-MM-dd");
                    input.phone = tbPersonPhone.Text;
                    input.address = tbPersonAddress.Text;
                    input.image_url = base64String;
                    input.group = tbPersonGroup.Text;
                    //SaveJpeg(pictureBox_Person.Image, @"d:\images.bmp", 100);

                    var serializer = new JavaScriptSerializer();
                    string jsonStr = serializer.Serialize(input);
                    request.AddJsonBody(jsonStr);
                    var AddPerson = client.Execute<AddPerson_Result>(request, Method.POST);



                    Console.WriteLine(AddPerson);

                    MessageBox.Show("บันทึกข้อมูลสำเร็จ!");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readCard();

        }
        public void readCard()
        {
            ThaiIDCard idcard = new ThaiIDCard();
            Personal personal = idcard.readAll();
            Personal personal1 = idcard.readAllPhoto();

            if (personal != null)
            {

                tbPersonFirstname.Text = personal.Th_Firstname;
                tbPersonLastname.Text = personal.Th_Lastname;
                tbPersonTitle.Text = personal.Th_Prefix;
                tbPersonCard.Text = personal.Citizenid;
                tbPersonBirthday.Text = personal.Birthday.ToString("yyyy-MM-dd");
                tbPersonAddress.Text = personal.Address;
                pictureBox_Person.Image = ByteToImage1(personal1.PhotoRaw);

                // Convert byte[] to Base64 String
                base64String = Convert.ToBase64String(personal1.PhotoRaw);

                // Write the bytes (as a Base64 string) to the textbox
                Console.WriteLine(base64String);

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
            //EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, (long)quality);
            //ImageCodecInfo jpegCodec = GetEncoderInfo("image/bmp");
            //EncoderParameters encoderParams = new EncoderParameters(1);
            //encoderParams.Param[0] = qualityParam;
            //img.Save(filename, jpegCodec, encoderParams);

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
            //byte[] pData = blob;
            //mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            //Bitmap bm = new Bitmap(mStream, false);
            //mStream.Dispose();
            return Image.FromStream(mStream);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

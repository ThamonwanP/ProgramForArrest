using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using zfm20;
using Encoder = System.Drawing.Imaging.Encoder;

namespace ProgramForArrest
{
    public partial class AddFingerprintForm : Form
    {
        string card;
        string base64String;
        private Zfm20Fingerprint _zfmSensor;
        string caseGroupID;
        string org;
        int fingerindex;
        string perId;

        // Default COM port settings. 
        private const string DefaultComPort = "COM5";
        private const int DefaultBaudRate = 115200;

        // Size of the fingerprint image. 
        private const int ImageWidth = 256;
        private const int ImageHeight = 288;

        public AddFingerprintForm(string card, string org)
        {
            InitializeComponent();
            this.card = card;
            this.org = org;
            
        }

        private void AddFingerprintForm_Load(object sender, EventArgs e)
        {
            _zfmSensor = new Zfm20Fingerprint(DefaultComPort, DefaultBaudRate);
            try
            {
                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/persons");
                var getPerson = client.Execute<List<GetAllPerson_data>>(request, Method.GET);

                int i = 0;

                while (getPerson.Data.Count > i)
                {
                    string[] Persons = new string[]
                    {
                            getPerson.Data[i].card.ToString(),
                            getPerson.Data[i].firstname,
                            getPerson.Data[i].lastname,
                            getPerson.Data[i].group,
                    };
                    listView_Persons.Items.Add(new ListViewItem(Persons));
                    i++;
                }

            }
            catch { }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
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

                        tbPersonCard.Text = getPersons.Data[0].card;
                        tbPersonFirstname.Text = getPersons.Data[0].firstname;
                        tbUserLastname.Text = getPersons.Data[0].lastname;
                        //DateTime bdate = UnixTimeStampToDateTime(getPersons.Data[0].birthday.value / 1000);
                        //tbPersonBirthday.Value = bdate.Subtract(new TimeSpan(7, 0, 0));
                        tbPersonPhone.Text = getPersons.Data[0].phone;
                        tbPersonGroup.Text = getPersons.Data[0].group;
                        perId = getPersons.Data[0].id;

                    }
                    i++;
                }

                RestClient client = new RestClient("http://202.28.34.197:8800");
                RestRequest request = new RestRequest("/ArrestSystem/group/" + tbPersonGroup.Text);
                var getGroup = client.Execute<GetCaseGroup>(request, Method.GET);

                caseGroupID = getGroup.Data.num;
                Console.WriteLine(caseGroupID);
            }
            catch { }
        }

        private void btScan_Click(object sender, EventArgs e)
        {
            try
            {

                string msgText = _zfmSensor.IsAvailable() ? @"Fingerprint sensor is available." : "Fingerprint sensor is not available.\nCheck sensor configuration options.";
                //MessageBox.Show(msgText, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Zfm20Fingerprint.ZfmStatus captureStatus = _zfmSensor.Capture();
                if (captureStatus != Zfm20Fingerprint.ZfmStatus.ZsSuccessful)
                {
 
                    //MessageBox.Show(ZfmStatusToString(captureStatus), Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                            // Paint bitmap buffer with received data buffer content.
                            for (int yPos = 0; yPos < ImageHeight; yPos++)
                            {
                                for (int xPos = 0; xPos < ImageWidth; xPos++)
                                {
                                    outputImage.SetPixel(xPos, yPos, Color.FromArgb(colorBuffer[bufferPos], colorBuffer[bufferPos], colorBuffer[bufferPos]));
                                    bufferPos++;
                                }
                            }

                            // Flush data buffer and show bitmap on UI.
                            _zfmSensor.FreeFingerprintBuffer(ref dataBuffer);
                            pictureBox_Finger.Image = outputImage;
                            pictureBox1.Image = outputImage;
                            byte[] bb = Relm.Converters.Converter.ToByteArray(pictureBox1.Image);
                            string hh = Convert.ToBase64String(bb);
                            Console.WriteLine("Original = " + hh);


                            Bitmap bmp = new Bitmap(pictureBox_Finger.Image);
                            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            pictureBox_Finger.Image = bmp;



                            //SaveJpeg(pictureBox_Finger.Image, @"d:\images.bmp", 100);
                            Console.WriteLine(pictureBox_Finger.ToString());
                            byte[] gg=Relm.Converters.Converter.ToByteArray(pictureBox_Finger.Image);
                            base64String = Convert.ToBase64String(gg);
                            
                            Console.WriteLine("Flip = "+base64String);


                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
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

        private void btAddFingerPrint_Click(object sender, EventArgs e)
        {
            if (radioLeft.Checked == true)
            {
                try
                {

                    AddTemple input = new AddTemple();
                    RestClient client = new RestClient("http://202.28.34.197:8800");
                    RestRequest request = new RestRequest("/fingerprintSystem/template/add");
                    FingerValue valueObj = new FingerValue();
                    
                    input.key = this.org;
                    valueObj.fingerid = perId;
                    valueObj.fingerindex = 0;
                    valueObj.fingergroup = caseGroupID;
                    valueObj.fingertemplate = base64String;
                    
                    input.value = valueObj;

                    var serializer = new JavaScriptSerializer();
                    string jsonStr = serializer.Serialize(input);
                    request.AddJsonBody(jsonStr);
                    var AddTemple = client.Execute<AddTemple_Result>(request, Method.POST);

                    string FingKey = AddTemple.Data.key;
                    //Console.WriteLine(a);

                    
                        AddFingerLeft inputFL = new AddFingerLeft();
                        RestClient FLclient = new RestClient("http://202.28.34.197:8800");
                        RestRequest FLrequest = new RestRequest("/ArrestSystem/person/updatefid/left/" + tbPersonCard.Text);

                        inputFL.fleft = FingKey;

                        var serializer1 = new JavaScriptSerializer();
                        string jsonStr1 = serializer.Serialize(inputFL);
                        FLrequest.AddJsonBody(jsonStr1);
                        var addFingLeft = FLclient.Execute<AddFingerLeft_Resual>(FLrequest, Method.POST);
                        MessageBox.Show("เพิ่มลายนิ้วมือข้อมูลสำเร็จ!");
                        Console.WriteLine(addFingLeft.Data.fright);
                        


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(radioRight.Checked == true)
            {
                try
                {
                    AddTemple input = new AddTemple();
                    RestClient client = new RestClient("http://202.28.34.197:8800");
                    RestRequest request = new RestRequest("/fingerprintSystem/template/add");
                    FingerValue valueObj = new FingerValue();

                    input.key = this.org;
                    valueObj.fingerid = perId;
                    valueObj.fingerindex = 1;
                    valueObj.fingergroup = caseGroupID;
                    valueObj.fingertemplate = base64String;

                    input.value = valueObj;

                    var serializer = new JavaScriptSerializer();
                    string jsonStr = serializer.Serialize(input);
                    request.AddJsonBody(jsonStr);
                    var AddTemple = client.Execute<AddTemple_Result>(request, Method.POST);

                    string FingKey = AddTemple.Data.key;
                    //Console.WriteLine(a);

                    //MessageBox.Show(FingKey);


                    AddFingerRight inputRight = new AddFingerRight();
                    RestClient FRclient = new RestClient("http://202.28.34.197:8800");
                    RestRequest FRrequest = new RestRequest("/ArrestSystem/person/updatefid/right/" + tbPersonCard.Text);

                    inputRight.fright = FingKey;

                    var serializer1 = new JavaScriptSerializer();
                    string jsonStr1 = serializer.Serialize(inputRight);
                    FRrequest.AddJsonBody(jsonStr1);
                    var addFingRight = FRclient.Execute<AddFingerRight_Result>(FRrequest, Method.POST);
                    Console.WriteLine(addFingRight.Data.fright);
                    MessageBox.Show("OK");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("กรุณาเลือกนิ้วมือ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}

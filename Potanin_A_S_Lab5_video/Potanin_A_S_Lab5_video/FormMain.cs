using DirectShowLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.Net.Sockets;
using NAudio.Wave;

namespace Potanin_A_S_Lab5_video
{
    public partial class FormMain : Form
    {
        private VideoCapture videoCapture = null;
        private DsDevice[] webCams = null;
        private int selectedCameraId = 0;
        //Подключены ли мы
        private bool connected;
        //сокет отправитель
        Socket client;
        //поток для нашей речи
        WaveIn input;
        //поток для речи собеседника
        WaveOut output;
        //буфферный поток для передачи через сеть
        BufferedWaveProvider bufferStream;
        //поток для прослушивания входящих сообщений
        private bool invers = false;
        public FormMain()
        {
            InitializeComponent();

            //создаем поток для записи нашей речи
            input = new WaveIn();
            //определяем его формат - частота дискретизации 8000 Гц, ширина сэмпла - 16 бит, 1 канал - моно
            input.WaveFormat = new WaveFormat(8000, 16, 2);
            //добавляем код обработки нашего голоса, поступающего на микрофон
            input.DataAvailable += Voice_Input;
            //создаем поток для прослушивания входящего звука
            output = new WaveOut();
            //создаем поток для буферного потока и определяем у него такой же формат как и потока с микрофона
            bufferStream = new BufferedWaveProvider(new WaveFormat(8000, 16,2));
            //привязываем поток входящего звука к буферному потоку
            output.Init(bufferStream);
        }
        //Обработка нашего голоса
        private void Voice_Input(object sender, WaveInEventArgs e)
        {
            try
            {
                //промежуточный буфер
                byte[] data = new byte[65535];
                data = e.Buffer;
                //добавляем данные в буфер, откуда output будет воспроизводить звук
                bufferStream.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripComboBoxCapture_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCameraId = toolStripComboBoxCapture.SelectedIndex;
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (webCams.Length == 0)
                {
                    throw new Exception("Нет доступных камер!");
                }
                else if (toolStripComboBoxCapture.SelectedItem == null)
                {
                    throw new Exception("Необходимо выбрать камеру!");
                }
                else if (videoCapture != null)
                {
                    videoCapture.Start();
                }
                else
                {
                    videoCapture = new VideoCapture(selectedCameraId);
                    videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
                    videoCapture.Start();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                videoCapture.Retrieve(m);
                Bitmap bitmap = m.ToImage<Bgr, byte>().Flip(Emgu.CV.CvEnum.FlipType.Horizontal).Bitmap;
                Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                if (invers)
                {
                    //for (int x = 0; x < newBitmap.Width; x++)
                    //{
                    //    for (int y = 0; y < newBitmap.Height; y++)
                    //    {
                    //        //Пиксель изображения на замену
                    //        Color oldColor = newBitmap.GetPixel(x, y);
                    //        //Задание нового пикселя для замены старого
                    //        Color newColor;
                    //        //Задаем значение нового пикселя
                    //        newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    //        //Заменяем новый пиксель вместо старого
                    //        newBitmap.SetPixel(x, y, newColor);
                    //    }
                    //}
                    //get a graphics object from the new image
                    
                    Graphics g = Graphics.FromImage(newBitmap);

                    // create the negative color matrix
                    ColorMatrix colorMatrix = new ColorMatrix(new float[][]
                    {
                        new float[] {-1, 0, 0, 0, 0},
                        new float[] {0, -1, 0, 0, 0},
                        new float[] {0, 0, -1, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {1, 1, 1, 0, 1}
                    });

                    // create some image attributes
                    ImageAttributes attributes = new ImageAttributes();

                    attributes.SetColorMatrix(colorMatrix);

                    g.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);

                    //dispose the Graphics object
                    g.Dispose();
                    bitmap = newBitmap;
                }

                pictureBox1.Image = (Image)bitmap.Clone();

                long totalMemory = GC.GetTotalMemory(false);

                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
            catch(Exception ex)
            {

            }
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture !=null)
                {
                    videoCapture.Pause();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture != null)
                {
                    videoCapture.Pause();
                    videoCapture.Dispose();
                    videoCapture = null;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                    selectedCameraId = 0;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OffInversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invers = false;
        }

        private void OnInversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invers = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            webCams = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < webCams.Length; i++)
            {
                toolStripComboBoxCapture.Items.Add(webCams[i].Name);
            }
        }


        private void OnVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.StartRecording();
            output.Play();
        }

        private void OffVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            output.Stop();
            input.StopRecording();
        }
    }
}

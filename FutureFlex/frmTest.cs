using System;
using System.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FutureFlex
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        private TcpClient tcpClient;
        private NetworkStream stream;
        private CancellationTokenSource cts;
        private Task receiveTask;


        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tcpClient = new TcpClient("127.0.0.1", 5000);
            stream = tcpClient.GetStream();
            stream.ReadTimeout = -1;
            cts = new CancellationTokenSource();

            receiveTask = Task.Run(async () =>
            {
                byte[] buffer = new byte[1024];
                while (!cts.Token.IsCancellationRequested)
                {
                    try
                    {
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cts.Token);
                        //  int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Console.WriteLine($"Received from server: {message}");
                    }
                    catch (OperationCanceledException)
                    {
                        Console.WriteLine("Read loop canceled.");
                        break;
                    }
                    catch (ObjectDisposedException)
                    {
                        Console.WriteLine("Stream already disposed.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception in reading: " + ex.Message);
                        break;
                    }
                }
            });

            Console.WriteLine("Connect success");
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cts?.Cancel();

                // รอให้ task ที่กำลังอ่านข้อมูลจบก่อน
                if (receiveTask != null)
                {
                    await receiveTask;
                }

                stream?.Close();
                tcpClient?.Close();
                Console.WriteLine("Disconnect success");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on disconnect: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = ConfigurationManager.AppSettings["TestValue"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            config.AppSettings.Settings["TestValue"].Value = guna2TextBox1.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}


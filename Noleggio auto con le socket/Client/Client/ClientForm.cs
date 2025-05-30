
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        TcpClient client;
        NetworkStream stream;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 5000);
                stream = client.GetStream();

                listBoxAuto.Items.AddRange(new string[]
                {
                    "Fiat Panda", "Ford Focus", "Toyota Yaris", "BMW Serie 1"
                });

                Thread readThread = new Thread(() =>
                {
                    while (client.Connected)
                    {
                        byte[] buffer = new byte[1024];
                        try
                        {
                            int byteCount = stream.Read(buffer, 0, buffer.Length);
                            string risposta = Encoding.UTF8.GetString(buffer, 0, byteCount);
                            Invoke((MethodInvoker)(() =>
                            {
                                MessageBox.Show(risposta);
                            }));
                        }
                        catch { break; }
                    }
                });
                readThread.IsBackground = true;
                readThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore di connessione: " + ex.Message);
            }
        }

        private void btnNoleggia_Click(object sender, EventArgs e)
        {
            if (textBoxAuto.Text != "")
            {
                string richiesta = textBoxAuto.Text;
                byte[] richiestaBytes = Encoding.UTF8.GetBytes(richiesta);
                stream.Write(richiestaBytes, 0, richiestaBytes.Length);
            }
        }
    }
}

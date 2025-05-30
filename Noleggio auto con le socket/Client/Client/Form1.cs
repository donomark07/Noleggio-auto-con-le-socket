using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            this.Load += ClientForm_Load; 
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ConnectToServer(); 
        }

        void ConnectToServer()
        {
            client = new TcpClient("127.0.0.1", 5000);
            stream = client.GetStream();

            string nome = txtNome.Text.Trim();
            byte[] nomeData = Encoding.UTF8.GetBytes("NOME:" + nome);
            stream.Write(nomeData, 0, nomeData.Length);

            Thread ricezioneThread = new Thread(ReceiveAuto);
            ricezioneThread.IsBackground = true;
            ricezioneThread.Start();
        }

        void ReceiveAuto()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytes;

                while ((bytes = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string elenco = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();
                    string messaggio = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();

                    if (messaggio.StartsWith("ERRORE:"))
                    {
                        
                        string testoErrore = messaggio.Substring(7);
                        MessageBox.Show(testoErrore, "Errore Noleggio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string[] auto = elenco.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);


                        if (listBoxAutoDisponibili.InvokeRequired)
                        {
                            if (listBoxAutoDisponibili.IsHandleCreated)
                            {
                                listBoxAutoDisponibili.Invoke(new MethodInvoker(() =>
                                {
                                    listBoxAutoDisponibili.Items.Clear();
                                    listBoxAutoDisponibili.Items.AddRange(auto);
                                }));
                            }
                        }
                        else
                        {
                            listBoxAutoDisponibili.Items.Clear();
                            listBoxAutoDisponibili.Items.AddRange(auto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella ricezione: " + ex.Message);
            }
        }


        private void btnNoleggia_Click(object sender, EventArgs e)
        {
            string autoScelta = txtAuto.Text.Trim();
            byte[] data = Encoding.UTF8.GetBytes(autoScelta);
            stream.Write(data, 0, data.Length);
        }

        private void btnInviaNome_Click(object sender, EventArgs e)
        {
            string nomeDaInviare = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nomeDaInviare))
            {
                MessageBox.Show("Inserisci un nome valido.");
                return;
            }

            string messaggio = "NOME:" + nomeDaInviare;  
            byte[] data = Encoding.UTF8.GetBytes(messaggio);
            stream.Write(data, 0, data.Length);
        }
    }
    }


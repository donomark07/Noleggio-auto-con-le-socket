
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class ServerForm : Form
    {
        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();
        Dictionary<string, bool> cars = new Dictionary<string, bool>()
        {
            {"Fiat Panda", true},
            {"Ford Focus", true},
            {"Toyota Yaris", true},
            {"BMW Serie 1", true}
        };

        public ServerForm()
        {
            InitializeComponent();
            StartServer();
        }

        private void StartServer()
        {
            Thread serverThread = new Thread(() =>
            {
                server = new TcpListener(IPAddress.Any, 5000);
                server.Start();
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
            });
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            string clientName = ((IPEndPoint)client.Client.RemoteEndPoint).ToString();
            Invoke((MethodInvoker)(() => listBoxClienti.Items.Add(clientName)));

            while (client.Connected)
            {
                try
                {
                    int byteCount = stream.Read(buffer, 0, buffer.Length);
                    string msg = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    Invoke((MethodInvoker)(() => listBoxLog.Items.Add($"Richiesta da {clientName}: {msg}")));
                    if (cars.ContainsKey(msg) && cars[msg])
                    {
                        cars[msg] = false;
                        UpdateAutoList();

                        string conferma = $"Auto '{msg}' assegnata con successo.";
                        byte[] confermaBytes = Encoding.UTF8.GetBytes(conferma);
                        stream.Write(confermaBytes, 0, confermaBytes.Length);
                    }
                    else
                    {
                        string errore = $"Auto '{msg}' non disponibile.";
                        byte[] erroreBytes = Encoding.UTF8.GetBytes(errore);
                        stream.Write(erroreBytes, 0, erroreBytes.Length);
                    }
                }
                catch { break; }
            }
        }

        private void UpdateAutoList()
        {
            Invoke((MethodInvoker)(() =>
            {
                listBoxAuto.Items.Clear();
                foreach (var car in cars)
                {
                    if (car.Value) listBoxAuto.Items.Add(car.Key);
                }
            }));
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            UpdateAutoList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener server;
        List<TcpClient> clients = new List<TcpClient>();
        List<string> autoDisponibili = new List<string> { "Fiat Panda", "Ford Focus", "BMW X3", "Tesla Model 3" };
        List<string> autoNoleggiate = new List<string>();
        Dictionary<string, string> clientNomi = new Dictionary<string, string>(); 


        public Form1()
        {
            InitializeComponent();
            foreach (var auto in autoDisponibili)
                listBoxAutoDisponibili.Items.Add(auto);

            Thread listenerThread = new Thread(StartServer);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        void StartServer()
        {
            server = new TcpListener(IPAddress.Any, 5000);
            server.Start();
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
                Invoke(new MethodInvoker(() => listBoxClient.Items.Add(client.Client.RemoteEndPoint.ToString())));

                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.IsBackground = true;
                clientThread.Start();
            }
        }



        void HandleClient(TcpClient client)
        {
            string clientEndpoint = client.Client.RemoteEndPoint.ToString();
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            
            int bytes = stream.Read(buffer, 0, buffer.Length);
            string primoMessaggio = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();

            string nome = "Sconosciuto";
            if (primoMessaggio.StartsWith("NOME:"))
            {
                nome = primoMessaggio.Substring(5).Trim();
                clientNomi[clientEndpoint] = nome;

                
                Invoke(new MethodInvoker(() =>
                {
                    int index = -1;
                    for (int i = 0; i < listBoxClient.Items.Count; i++)
                    {
                        if (listBoxClient.Items[i].ToString().Contains(clientEndpoint))
                        {
                            index = i;
                            break;
                        }
                    }

                    string nuovaVoce = $"{nome} ({clientEndpoint})";

                    if (index != -1)
                        listBoxClient.Items[index] = nuovaVoce;
                    else
                        listBoxClient.Items.Add(nuovaVoce);
                }));
            }

            
            SendAutoDisponibili(stream);

            
            while ((bytes = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string messaggio = Encoding.UTF8.GetString(buffer, 0, bytes).Trim();

                if (messaggio.StartsWith("NOME:"))
                {
                    string nuovoNome = messaggio.Substring(5).Trim();
                    clientNomi[clientEndpoint] = nuovoNome;

                    Invoke(new MethodInvoker(() =>
                    {
                        int index = -1;
                        for (int i = 0; i < listBoxClient.Items.Count; i++)
                        {
                            if (listBoxClient.Items[i].ToString().Contains(clientEndpoint))
                            {
                                index = i;
                                break;
                            }
                        }

                        string nuovaVoce = $"{nuovoNome} ({clientEndpoint})";

                        if (index != -1)
                            listBoxClient.Items[index] = nuovaVoce;
                        else
                            listBoxClient.Items.Add(nuovaVoce);

                        listBoxMonitorNoleggi.Items.Add($"Client {nuovoNome} ({clientEndpoint}) si è aggiornato.");
                    }));

                    continue; 
                }

                
                if (autoDisponibili.Contains(messaggio))
                {
                   
                    autoDisponibili.Remove(messaggio);
                    autoNoleggiate.Add(messaggio);

                    Invoke(new MethodInvoker(() =>
                    {
                        listBoxAutoDisponibili.Items.Remove(messaggio);
                        listBoxAutoNoleggiate.Items.Add(messaggio);
                    }));

                    AggiornaTuttiClient();

                    
                    Thread restituzioneThread = new Thread(() =>
                    {
                        Random rand = new Random();
                        int delay = rand.Next(3000, 10000); 
                        int secondi = delay / 1000;

                        string nomeClient = clientNomi.ContainsKey(clientEndpoint) ? clientNomi[clientEndpoint] : "Sconosciuto";
                        string messaggioNoleggio = $"{nomeClient} ha noleggiato {messaggio} per {secondi} secondi";

                        Invoke(new MethodInvoker(() =>
                        {
                            listBoxMonitorNoleggi.Items.Add(messaggioNoleggio);
                        }));

                        Thread.Sleep(delay);

                        autoNoleggiate.Remove(messaggio);
                        autoDisponibili.Add(messaggio);

                        Invoke(new MethodInvoker(() =>
                        {
                            listBoxAutoNoleggiate.Items.Remove(messaggio);
                            listBoxAutoDisponibili.Items.Add(messaggio);
                        }));

                        AggiornaTuttiClient();

                        string messaggioRestituzione = $"{nomeClient} ha restituito {messaggio}";
                        Invoke(new MethodInvoker(() =>
                        {
                            listBoxMonitorNoleggi.Items.Add(messaggioRestituzione);
                        }));
                    });
                    restituzioneThread.IsBackground = true;
                    restituzioneThread.Start();
                }
                else
                {
                    
                    string messaggioErrore = $"ERRORE:L'auto '{messaggio}' non è disponibile.";
                    byte[] dataErrore = Encoding.UTF8.GetBytes(messaggioErrore);
                    try
                    {
                        stream.Write(dataErrore, 0, dataErrore.Length);
                    }
                    catch {  }
                }
            }

            
            clients.Remove(client);
            Invoke(new MethodInvoker(() =>
            {
               
                for (int i = 0; i < listBoxClient.Items.Count; i++)
                {
                    if (listBoxClient.Items[i].ToString().Contains(clientEndpoint))
                    {
                        listBoxClient.Items.RemoveAt(i);
                        break;
                    }
                }
            }));
        }





        void SendAutoDisponibili(NetworkStream stream)
        {
            string elenco = string.Join("|", autoDisponibili);
            byte[] data = Encoding.UTF8.GetBytes(elenco);
            stream.Write(data, 0, data.Length);
        }

        void AggiornaTuttiClient()
        {
            string elenco = string.Join("|", autoDisponibili);
            byte[] data = Encoding.UTF8.GetBytes(elenco);
            foreach (var c in clients)
            {
                try
                {
                    c.GetStream().Write(data, 0, data.Length);
                }
                catch { }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        
    }
}

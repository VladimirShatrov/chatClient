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

namespace RSClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnected = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(txtServerIP.Text, 8080);
                stream = client.GetStream();
                isConnected = true;
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
                string message = txtUsername.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                AppendMessage("Подключено к серверу.");
            }
            catch (Exception ex)
            {
                AppendMessage("Ошибка подключения: " + ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isConnected && !string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                string message = txtUsername.Text + ":" + txtMessage.Text;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                txtMessage.Clear();
            }
        }

        private void ReceiveMessages()
        {
            try
            {
                while (isConnected)
                {
                    byte[] data = new byte[1024];
                    int bytes = stream.Read(data, 0, data.Length);
                    if (bytes == 0) break;
                    string message = Encoding.UTF8.GetString(data, 0, bytes);
                    AppendMessage(message);
                }
            }
            catch (Exception ex)
            {
                AppendMessage("Ошибка: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        private void AppendMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendMessage), message);
            }
            else
            {
                txtChat.AppendText(message + Environment.NewLine);
            }
        }

        private void Disconnect()
        {
            isConnected = false;
            stream?.Close();
            client?.Close();
            AppendMessage("Отключено от сервера.");
        }

        private void ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
    }
}

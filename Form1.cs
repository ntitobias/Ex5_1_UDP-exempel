using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5_1_UDP_klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            //Skicka ett meddealnde till en server

            //Deklarera vart vi ska skicka meddelandet
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            IPEndPoint destination = new IPEndPoint(serverIP, 12345);

            //Omvandla meddelandet till något som går att skicka
            byte[] message = Encoding.Unicode.GetBytes(tbxMeddelande.Text);

            //Skapa en klient
            UdpClient klient = new UdpClient();

            //Skicka meddelandet
            klient.Send(message, message.Length, destination);
        }
    }
}

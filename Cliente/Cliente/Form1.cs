using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClsCalcular;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TcpClientChannel chanel = new TcpClientChannel();
            ChannelServices.RegisterChannel(chanel, false);
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Calculadora), "tcp://localhost:1235/Calculadora");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculadora Opera = new Calculadora();
            int n1, n2;
            n1 = Int16.Parse(textBox1.Text);
            n2 = Int16.Parse(textBox2.Text);
            this.textBox3.Text = Opera.suma(n1, n2).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace ProjetoFontes
{
    public partial class Form1 : Form
    {
        string RxString;

        public Form1()
        {
            InitializeComponent();
        }
        private void atualiza_listaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cbbox_conectar.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cbbox_conectar.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            cbbox_conectar.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cbbox_conectar.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cbbox_conectar.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //trycatch conexão, botão muda estado
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialport_01.IsOpen == false)
            {
                try
                {
                    serialport_01.PortName = cbbox_conectar.Items[cbbox_conectar.SelectedIndex].ToString();
                    serialport_01.Open();

                }
                catch
                {
                    return;

                }
                if (serialport_01.IsOpen)
                {
                    bt_conectar.Text = "Desconectar";
                    cbbox_conectar.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialport_01.Close();
                    cbbox_conectar.Enabled = true;
                    bt_conectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void timer_com_Tick(object sender, EventArgs e)
        {
            atualiza_listaCOMs();
        }
    
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        if (serialport_01.IsOpen == true)  // se porta aberta
            serialport_01.Close();         //fecha a porta
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (serialport_01.IsOpen == true)          //porta está aberta
                serialport_01.Write(txbox_enviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialport_01.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            txbox_receber.AppendText(RxString);
        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbox_conectar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

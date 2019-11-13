using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;


namespace MODBUSTCPClient
{
    public partial class Form1 : Form
    {
        ModbusClient modbus;
        public Form1()
        {
            InitializeComponent();
        }
        public bool ValidateIPV4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }
            string[] splitValues = ipString.Split('.');
            if(splitValues.Length != 4)
            {
                return false;
            }
            byte tempForParsing;
            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        private void bt_connect_Click(object sender, EventArgs e)
        {

            short port;
            if (ValidateIPV4(tb_ip.Text)&& Int16.TryParse(tb_porta.Text, out port))
            {
                modbus = new ModbusClient(tb_ip.Text, port);
                modbus.ConnectionTimeout = 3000;

                if(bt_connect.Text == "Conectar")
                {
                    try
                    {
                        modbus.Connect();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                        return;
                        
                    }
                    bt_connect.Text = "Desconectar";
                    bt_bobinas.Enabled = true;
                    bt_regEntrada.Enabled = true;
                    bt_regHold.Enabled = true;
                    bt_enDiscretas.Enabled = true;
                }
                else
                {
                    bt_connect.Text = "Conectar";
                    bt_bobinas.Enabled = false;
                    bt_regEntrada.Enabled = false;
                    bt_regHold.Enabled = false;
                    bt_enDiscretas.Enabled = false;
                    modbus.Disconnect();

                }

            }
            else
            {
                MessageBox.Show("IP ou porta invalidos");
            }
        }
        public void lerDados(int tipo)
        {
            int startadd, quant;
            string[] dados = new string[1];

            try
            {
                if (modbus.Connected)
                {
                    if (int.TryParse(tb_endi.Text, out startadd) && int.TryParse(tb_quantidade.Text, out quant)
                    {
                        tb_dados.Text = "";

                        switch (tipo)
                        {
                            case 1:
                                bool[] dadosCo = modbus.ReadCoils(startadd, quant);
                                dados = dadosCo.Select(x => x.ToString()).ToArray();
                                break;
                            case 2:
                                bool[] dadosDI = modbus.ReadDiscreteInputs(startadd, quant);
                                dados = dadosDI.Select(x => x.ToString()).ToArray();
                                break;
                            case 3:
                                int[] dadosHR = modbus.ReadHoldingRegisters(startadd, quant);
                                dados = dadosHR.Select(x => x.ToString()).ToArray();
                                break;
                            case 4:
                                int[] dadosIR = modbus.ReadInputRegisters(startadd, quant);
                                dados = dadosIR.Select(x => x.ToString()).ToArray();
                                break;
                        }

                        for (int i = 0; i < dados.Length; i++)
                        {
                            tb_dados.Text += "Dado " + i.ToString() + ": " + dados[i].ToString() + "\r\n";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Servidor MODBUS TCP Desconectado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro na leitura dos dados MODBUS. \r\nErro: " + err.Message);
            }
        }

        private void bt_bobinas_Click(object sender, EventArgs e)
        {
            lerDados(1);
        }

        private void bt_enDiscretas_Click(object sender, EventArgs e)
        {
            lerDados(2);
        }

        private void bt_regEntrada_Click(object sender, EventArgs e)
        {
            lerDados(3);
        }

        private void bt_regHold_Click(object sender, EventArgs e)
        {
            lerDados(4);
        }
    }
}




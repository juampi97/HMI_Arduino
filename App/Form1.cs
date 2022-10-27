using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonConect.Enabled = true;
            buttonDesconect.Enabled = false;
            labelStatus.BackColor = Color.Red;
            comboBoxBAUD.Text = "9600";
            progressBarStatus.Value = 0;

            string[] portList = SerialPort.GetPortNames();
            comboBoxPORT.Items.AddRange(portList);

            labelStatus.BackColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void buttonConect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBAUD.Text);
                serialPort1.Open();

                buttonConect.Enabled = false;
                buttonDesconect.Enabled = true;
                progressBarStatus.Value = 100;
                comboBoxPORT.Enabled = false;
                comboBoxBAUD.Enabled = false;

                labelStatus.BackColor= Color.Green;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonDesconect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    buttonConect.Enabled = true;
                    buttonDesconect.Enabled = false;

                    progressBarStatus.Value = 0;
                    comboBoxPORT.Enabled = true;
                    comboBoxBAUD.Enabled = true;

                    labelStatus.BackColor = Color.Red;

                    label_TempValue.Text = "-";
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string serialData = serialPort1.ReadLine();
                int value = Convert.ToInt32(serialData);

                label_TempValue.Text = value.ToString();

                //chartTemp.Series["Temperatura"].Points.AddY(value);
                chartTemp.Invoke((MethodInvoker)(() => chartTemp.Series["Temperatura"].Points.AddY(value)));
            }
        }

        private void chartTemp_Click(object sender, EventArgs e)
        {

        }
    }
}

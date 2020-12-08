using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace modbusTest
{
    public partial class Form1 : Form
    {
        
        SerialPort serialPort = new SerialPort(/*"123", 19200, Parity.Even, 8*/);

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialCloseBtn.Enabled = false;
            TimerStopBtn.Enabled = false;
            TimerStartBtn.Enabled = false;
            TimerStopBtn.Enabled = false;
            TextDataBtn.Enabled = false;
            Box_initialization();
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

        }


        private void SerialSet_LockOrNot()
        {
            SerialComboBox.Enabled     = !SerialComboBox.Enabled;
            SpeedComboBox.Enabled      = !SpeedComboBox.Enabled;
            ParityComboBox.Enabled     = !ParityComboBox.Enabled;
            DataBitsComboBox.Enabled   = !DataBitsComboBox.Enabled;
            StopBitsComboBox.Enabled   = !StopBitsComboBox.Enabled;
            SerialSortCheckbox.Enabled = !SerialSortCheckbox.Enabled;
        }

        private void SerialConnectBtn_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort.PortName = SerialComboBox.Text;
                serialPort.BaudRate = Convert.ToInt32(SpeedComboBox.Text);
                switch (ParityComboBox.SelectedItem)
                {
                    case "none":
                        serialPort.Parity = Parity.None;
                        break;
                    case "Odd":
                        serialPort.Parity = Parity.Odd;
                        break;
                    case "Even":
                        serialPort.Parity = Parity.Even;
                        break;
                }
                serialPort.DataBits = Convert.ToInt32(DataBitsComboBox.SelectedItem);
                switch (StopBitsComboBox.SelectedItem)
                {
                    case '1':
                        serialPort.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        serialPort.StopBits = StopBits.OnePointFive;
                        break;
                    case '2':
                        serialPort.StopBits = StopBits.Two;
                        break;
                }

                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error/*,MessageBoxDefaultButton.Button1,0,"https://google.com"*/);
                return;
            }
            /*catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(System.IO.IOException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            
            SerialConnectBtn.Enabled = false;
            SerialCloseBtn.Enabled = true;
            TimerStartBtn.Enabled = true;
            TimerStopBtn.Enabled = false;
            TextDataBtn.Enabled = true;
            SerialSet_LockOrNot();
        }

        private void SerialCloseBtn_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            timer1.Enabled = false;
            SerialConnectBtn.Enabled = true;
            SerialCloseBtn.Enabled = false;
            TimerStartBtn.Enabled = false;
            TimerStopBtn.Enabled = false;
            TextDataBtn.Enabled = false;
            SerialSet_LockOrNot();
        }

        private void serialComboBox_initialization()
        {
            SerialComboBox.Items.Clear();
            if (SerialSortCheckbox.Checked)
            {
                String[] serialPortName = SerialPort.GetPortNames();
                for (UInt16 i = 0; i < serialPortName.Length; i++)
                {
                    SerialComboBox.Items.Add(serialPortName[i]);
                }
            }
            else
            {
                for (UInt16 i = 1; i <= 18; i++)
                {
                    SerialComboBox.Items.Add("COM" + i);
                }
            }
            SerialComboBox.SelectedIndex = 0;
        }

        private void Box_initialization()
        {
            serialComboBox_initialization();

            String[] speedComboBoxItems = { "2400", "4800", "9600", "19200", "38400", "57600" };
            SpeedComboBox.Items.AddRange(speedComboBoxItems);
            SpeedComboBox.SelectedIndex = 2;

            String[] parityComboBoxItems = { "none", "Odd", "Even" };
            ParityComboBox.Items.AddRange(parityComboBoxItems);
            ParityComboBox.SelectedIndex = 0;

            String[] dataBitsComboBoxItems = { "6", "7", "8" };
            DataBitsComboBox.Items.AddRange(dataBitsComboBoxItems);
            DataBitsComboBox.SelectedIndex = 2;

            String[] stopBitsComboBoxItems = { "1", "1.5", "2" };
            StopBitsComboBox.Items.AddRange(stopBitsComboBoxItems);
            StopBitsComboBox.SelectedIndex = 0;

            IntervalTextBox.Text = "100";
            DataTextComboBox.Text = "01 03 00 00 00 01";
        }

        private void SerialSortCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            serialComboBox_initialization();
        }

        private void TextDataBtn_Click(object sender, EventArgs e)
        {
            if (DataTextComboBox.Text == "")
            {
                MessageBox.Show("請填入數值", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Data_put();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PutTextBox.Text = "";
            GetTextBox.Text = "";
        }

        private void TimerStartBtn_Click(object sender, EventArgs e)
        {
            TimerStartBtn.Enabled = false;
            TimerStopBtn.Enabled = true;
            timer1.Interval = Convert.ToInt32(IntervalTextBox.Text);
            timer1.Enabled = true;
        }

        private void TimerStopBtn_Click(object sender, EventArgs e)
        {
            TimerStartBtn.Enabled = true;
            TimerStopBtn.Enabled = false;
            timer1.Enabled = false;
        }

        static ushort CRC16(ArrayList pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            foreach (Byte data in pDataBytes)
            {
                crc ^= data;
                for (Int16 i = 0; i < 8; i++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            return crc;
        }

        byte String2Hex(String inData)
        {
            byte outData = 0x00;

            for(UInt16 i = 0; i < inData.Length; i++)
            {
                if(inData[i] <= '9')
                {
                    outData += Convert.ToByte(inData[i] - '0');
                }
                else
                {
                    outData += Convert.ToByte(inData[i] - 'A' + 10);
                }

                if (i == 0) outData <<= 4;
            }

            return outData;
        }

        String getData = "";

        private void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String inData = "";

            while (sp.BytesToRead > 0)
            {
                inData = sp.ReadByte().ToString("X2");
                getData += inData + " ";
                if (sp.BytesToRead == 0)
                {
                    Thread.Sleep(3);
                }
            }

            if (getData != "")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (GetTextBox.Lines.Length >= 100)
                    {
                        GetTextBox.Text = "";
                    }

                    GetTextBox.Text += getData + "\r\n";
                });
                getData = "";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool dataPutResult;
            dataPutResult = Data_put();
            if (!dataPutResult)
            {
                TimerStartBtn.Enabled = true;
                TimerStopBtn.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private bool Data_put()
        {

            String[] calText = DataTextComboBox.Text.Split(' ');
            String putText = ""; //存放發送的字串 並顯示於DataTextComboBox和PutTextBox
            ArrayList putData = new ArrayList();

            foreach (String i in calText)
            {
                if (i.Length > 2)
                {
                    MessageBox.Show("溢位", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                String temp;
                temp = i;

                if (i.CompareTo(" ") != -1)
                {
                    if (i.Length == 1)
                    {
                        temp = '0' + temp;
                    }
                    putText += temp + ' ';
                    putData.Add(String2Hex(temp.ToUpper()));
                }
            }

            putText = putText.Substring(0,putText.Length-1);

            for(UInt16 i = 0; i <= DataTextComboBox.Items.Count; i++) {
                if (i == DataTextComboBox.Items.Count)
                {
                    DataTextComboBox.Items.Add(putText);
                    break;
                }
                
                if (putText == DataTextComboBox.Items[i].ToString()) {
                   break;
                }
            }
            

            if (CrCcheckBox.Checked)
            {
                ushort CrC = CRC16(putData);
                byte byteCrC = Convert.ToByte(CrC & 0xFF);
                putText += " " + byteCrC.ToString("X2");
                putData.Add(byteCrC);

                byteCrC = Convert.ToByte(CrC >> 8);
                putText += " " + byteCrC.ToString("X2");
                putData.Add(byteCrC);
            }
            byte[] array = (byte[])putData.ToArray(typeof(byte));
            serialPort.Write(array, 0, array.Length);

            if (PutTextBox.Lines.Length >= 100)
            {
                PutTextBox.Text = "";
            }
            

            PutTextBox.Text += putText + "\r\n";
            return true;
        }
    }
}

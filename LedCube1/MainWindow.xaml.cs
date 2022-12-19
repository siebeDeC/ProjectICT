using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LedCube1;
using LedCubeOff;
using Figures;

namespace LedCube1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort;
        LedsColors led;
        LedsUit led1;
        LedFigures led2;
        byte[] data = new byte[81];

        public MainWindow()
        {
            InitializeComponent();

            led = new LedsColors();
            led1 = new LedsUit();
            led2 = new LedFigures();
            

            cbxPortName.Items.Add("None");
            foreach (string s in SerialPort.GetPortNames())
                cbxPortName.Items.Add(s);

            _serialPort = new SerialPort();
            _serialPort.BaudRate = 250000;
            _serialPort.StopBits = StopBits.Two;
        }

        private void cbxPortName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                if (cbxPortName.SelectedItem.ToString() != "None")
                {
                    _serialPort.PortName = cbxPortName.SelectedItem.ToString();
                    _serialPort.Open();
                }
            }
        }

        private void BtnGreen_Click(object sender, RoutedEventArgs e)
        {
            led.Green(data, _serialPort);
        }

        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            led.Red(data, _serialPort);
        }

        private void BtnBlauw_Click(object sender, RoutedEventArgs e)
        {
            led.Blue(data, _serialPort);
        }

        private void LedsUit_Click(object sender, RoutedEventArgs e)
        {
            led1.Off(data, _serialPort);
        }

       private void Diamant_Click(object sender, RoutedEventArgs e)
        {
            led2.Diamant(data, _serialPort);
        }

        private void Kubus_Click(object sender, RoutedEventArgs e)
        {
            led2.Kubus(data, _serialPort);
        }

 
    }
}

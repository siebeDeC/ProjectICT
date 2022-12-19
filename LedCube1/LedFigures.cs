using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class LedFigures
    {
        public void Diamant(byte[] test, SerialPort serialport)
        {
            test = new byte[81];
            test[9] = 255;
            test[12] = 255;
            test[15] = 255;
            test[30] = 255;
            test[36] = 255;
            test[39] = 255;
            test[42] = 255;
            test[48] = 255;
            test[63] = 255;
            test[66] = 255;
            test[69] = 255;

            serialport.Write(test, 0, 81);
        }

        public void Kubus(byte[] test, SerialPort serialport)
        {
            test = new byte[81];
            test[0] = 255;
            test[3] = 255;
            test[6] = 255;
            test[9] = 255;
            test[15] = 255;
            test[18] = 255;
            test[21] = 255;
            test[24] = 255;
            test[27] = 255;
            test[33] = 255;
            test[45] = 255;
            test[51] = 255;
            test[53] = 255;
            test[57] = 255;
            test[60] = 255;
            test[63] = 255;
            test[69] = 255;
            test[72] = 255;
            test[75] = 255;
            test[78] = 255;

            serialport.Write(test, 0, 81);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedCube1
{
    class LedsColors
    {
        public void Green(byte[] test, SerialPort serialport)
        {
            test = new byte[81];
            test[1] = 255;
            test[4] = 255;
            test[7] = 255;
            test[10] = 255;
            test[13] = 255;
            test[16] = 255;
            test[19] = 255;
            test[22] = 255;
            test[25] = 255;
            test[28] = 255;
            test[31] = 255;
            test[34] = 255;
            test[37] = 255;
            test[40] = 255;
            test[43] = 255;
            test[46] = 255;
            test[49] = 255;
            test[52] = 255;
            test[55] = 255;
            test[58] = 255;
            test[61] = 255;
            test[64] = 255;
            test[67] = 255;
            test[70] = 255;
            test[73] = 255;
            test[76] = 255;
            test[79] = 255;

            serialport.Write(test, 0, 81);
        }

        public void Red(byte[] test, SerialPort serialport)
        {
            test = new byte[81];
            test[0] = 255;
            test[3] = 255;
            test[6] = 255;
            test[9] = 255;
            test[12] = 255;
            test[15] = 255;
            test[18] = 255;
            test[21] = 255;
            test[24] = 255;
            test[27] = 255;
            test[30] = 255;
            test[33] = 255;
            test[36] = 255;
            test[39] = 255;
            test[42] = 255;
            test[45] = 255;
            test[48] = 255;
            test[51] = 255;
            test[54] = 255;
            test[57] = 255;
            test[60] = 255;
            test[63] = 255;
            test[66] = 255;
            test[69] = 255;
            test[72] = 255;
            test[75] = 255;
            test[78] = 255;
             
            serialport.Write(test, 0, 81);
        }

        public void Blue(byte[] test,SerialPort serialPort)
        {
            test = new byte[81];
            test[2] = 255;
            test[5] = 255;
            test[8] = 255;
            test[11] = 255;
            test[14] = 255;
            test[17] = 255;
            test[20] = 255;
            test[23] = 255;
            test[26] = 255;
            test[29] = 255;
            test[32] = 255;
            test[35] = 255;
            test[38] = 255;
            test[41] = 255;
            test[44] = 255;
            test[47] = 255;
            test[50] = 255;
            test[53] = 255;
            test[56] = 255;
            test[59] = 255;
            test[62] = 255;
            test[65] = 255;
            test[68] = 255;
            test[71] = 255;
            test[74] = 255;
            test[77] = 255;
            test[80] = 255;

            serialPort.Write(test, 0, 81);
        }
    }
}

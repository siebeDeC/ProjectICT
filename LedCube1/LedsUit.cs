using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedCubeOff
{
    class LedsUit
    {
        public void Off(byte[] test, SerialPort serialPort)
        {
            test = new byte[81];

                test[0] = 0;
                test[1] = 0;
                test[2] = 0;
                test[3] = 0;
                test[4] = 0;
                test[5] = 0;
                test[6] = 0;
                test[7] = 0;
                test[8] = 0;
                test[9] = 0;
                test[10] = 0;
                test[11] = 0;
                test[12]= 0;
                test[13] = 0;
                test[14] = 0;
                test[15] = 0;
                test[16] = 0;
                test[17] = 0;
                test[18] = 0;
                test[19] = 0;
                test[20] = 0;
                test[21] = 0;
                test[22] = 0;
                test[23] = 0;
                test[24] = 0;
                test[25] = 0;
                test[26] = 0;
                test[27] = 0;
                test[28] = 0;
                test[29] = 0;
                test[30] = 0;
                test[31] = 0;
                test[32] = 0;
                test[32] = 0;
                test[33] = 0;
                test[34] = 0;
                test[35] = 0;
                test[36] = 0;
                test[37] = 0;
                test[38] = 0;
                test[39] = 0;
                test[40] = 0;
                test[41] = 0;
                test[42] = 0;
                test[43] = 0;
                test[44] = 0;
                test[45] = 0;
                test[46] = 0;
                test[47] = 0;
                test[48] = 0;
                test[49] = 0;
                test[50] = 0;
                test[51] = 0;
                test[52] = 0;
                test[53] = 0;
                test[54] = 0;
                test[55] = 0;
                test[56] = 0;
                test[57] = 0;
                test[58] = 0;
                test[59] = 0;
                test[60] = 0;
                test[61] = 0;
                test[62] = 0;
                test[63] = 0;
                test[64] = 0;
                test[65] = 0;
                test[66] = 0;
                test[67] = 0;
                test[68] = 0;
                test[69] = 0;
                test[70] = 0;
                test[71] = 0;
                test[72] = 0;
                test[73] = 0;
                test[74] = 0;
                test[75] = 0;
                test[76] = 0;
                test[77] = 0;
                test[78] = 0;
                test[79] = 0;
                test[80] = 0;

            serialPort.Write(test, 0, 81);

        }
    }
}

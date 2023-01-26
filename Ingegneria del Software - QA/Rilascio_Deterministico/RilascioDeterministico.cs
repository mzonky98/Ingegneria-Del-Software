using System;
using System.IO;

namespace Ingegneria_del_Software___QA.Rilascio_Deterministico
{
    public class RilascioDeterministico
    {
        public void Main()
        {
            Byte[] bytesToWrite = new Byte[] {1, 2, 3, 4, 5};
            FileStream fs = null;
            try
            {
                fs = new FileStream("Temp.dat", FileMode.Create);
                fs.Write(bytesToWrite, 0, bytesToWrite.Length);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
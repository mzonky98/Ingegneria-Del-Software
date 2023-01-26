using System;
using System.IO;

namespace Ingegneria_del_Software___QA.Rilascio_Deterministico
{
    public class RilascioDet_conPatternDispose
    {
        public void Main()
        {
            Byte[] bytesToWrite = new Byte[] {1, 2, 3, 4, 5};
            using (FileStream fs = new FileStream("Temp.dat", FileMode.Create))
            {
                fs.Write(bytesToWrite, 0, bytesToWrite.Length);
            }
        }
    }
}
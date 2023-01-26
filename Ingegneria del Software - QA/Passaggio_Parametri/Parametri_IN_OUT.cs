using System;
using Ingegneria_del_Software___QA.Tipi_di_Dato;

namespace Ingegneria_del_Software___QA.Passaggio_Parametri
{
    public class Parametri_IN_OUT
    {
        public void Main()
        {
            PostoRistorante posto = new PostoRistorante(1, 1);
            AssignSeat(ref posto);
            Console.WriteLine(posto);
        }

        static void AssignSeat(ref PostoRistorante posto)
        {
            posto.TableNumber = 3;
            posto.TableSeat = 5;
        }
    }
}
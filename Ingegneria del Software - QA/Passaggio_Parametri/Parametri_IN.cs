using System;

namespace Ingegneria_del_Software___QA.Passaggio_Parametri
{
    public class Parametri_IN
    {
        public void Main()
        {
            PostoRistorante posto = new PostoRistorante(1, 1);
            AssignSeat(in posto);
            Console.WriteLine(posto);   
            // Dovrebbe stampare (1,1) => 
            // tramite keyword "in" si passa una copia del riferimento indipendente dall'originale
        }

        static void AssignSeat(in PostoRistorante posto)
        {
            posto.TableNumber = 3;
            posto.TableSeat = 5;
        }
    }
}
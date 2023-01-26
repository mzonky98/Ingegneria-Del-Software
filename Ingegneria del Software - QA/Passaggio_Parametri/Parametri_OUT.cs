using System;

namespace Ingegneria_del_Software___QA.Passaggio_Parametri
{
    public class Parametri_OUT
    {
        public void Main()
        {
            PostoRistorante posto = new PostoRistorante(1, 1);
            AssignSeat(out posto);
            // Diventa un parametro da usare come output per la funzione invocata (come in C con in puntatori)
        }

        static void AssignSeat(out PostoRistorante posto)
        {
            posto = new PostoRistorante(3, 5);
        }
    }
}
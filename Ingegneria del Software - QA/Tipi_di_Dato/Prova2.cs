using System;

namespace Ingegneria_del_Software___QA.Tipi_di_Dato
{
    public class Prova2
    {
        public void Main()
        {
            double d = 333.3;
            Object obj = d;

            double d2 = (double) obj;
            
            // -----

            PostoRistorante posto = new PostoRistorante(1, 1);
            
            AssignSeat(ref posto);
            
            Console.WriteLine(posto);
            // Se RestaurantReservation è una classe si ha (3,5)
            // se è una struttura si ha (1,1)

            posto = new PostoRistorante(1, 1);
            
            // with "out" we pass the virtual memory address of the variable "posto"
            AssignSeat_alt(out posto);

        }
        
        static void AssignSeat(ref PostoRistorante posto)
        {
            posto.TableNumber = 3;
            posto.TableSeat = 5;
        }

        static void AssignSeat_alt(out PostoRistorante posto)
        {
            posto = new PostoRistorante(3, 5);
        }

        public void Main_alt()
        {
            var d = 333.3;
            var obj = d;    // Not working as above

            var d2 = (double) obj;
        }
    }
}
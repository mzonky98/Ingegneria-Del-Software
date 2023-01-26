using System.Reflection;

namespace Ingegneria_del_Software___QA.Tipi_di_Dato
{
    public class Prova
    {
        public void Main()
        {
            PostoRistorante posto = new PostoRistorante(1, 1);
            var type = posto.GetType();

            
        }
    }
}
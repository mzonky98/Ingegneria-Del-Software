namespace Ingegneria_del_Software___QA.Esempi
{
    public class Costruttori
    {
        
    }

    // Viene definito implicitamente un costruttore di tipo
    class MyType1
    {
        private static int _x = 5;
    }

    // Analogo a sopra
    class MyType2
    {
        private static int _x;

        public MyType2()
        {
            _x = 5;
        }
    }
    
    // x viene inizializzato a 5 e poi subito dopo a 10
    class MyType3
    {
        private static int _x = 5;

        public MyType3()
        {
            _x = 10;
        }
    }
}
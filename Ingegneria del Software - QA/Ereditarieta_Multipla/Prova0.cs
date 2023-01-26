using System;

namespace Ingegneria_del_Software___QA.Ereditarieta_Multipla
{
    interface Flyable
    {
        void Fly();
    }

    interface Swimmable
    {
        void Swim();
    }

    class Seaplane : Swimmable, Flyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }
    }
    
}
using System;

namespace Ingegneria_del_Software___QA.Polimorfismo
{
    // Defining class A with two virtual methods (methods that can be overriden from classes inheriting from A)
    public class A
    {
        public virtual void Fun1(int x)
        {
            
        }
        
        public virtual void Fun2(int x)
        {
            
        }
    }

    // Class B inherits from class A  
    public class B : A
    {
        public override void Fun1(int x)
        {
            
        }

        public override void Fun2(int x)
        {
            
        }
    }
}
namespace Ingegneria_del_Software___QA.Rilascio_Deterministico
{
    public class PatternDispose
    {
        // If class T wants to offer to its users a method to clean up after use, it must implements the IDisposable Interface
        public interface IDisposable
        {
            void Dispose();
        }

        public class MyType : System.IDisposable
        {
            public void Dispose()
            {
                // TODO: clean up actions
            }
            // ...
        }
        
        public class Client
        {
            public void Main()
            {
                using (MyType tx = new MyType())
                {
                    // usage of tx...
                }
            }
        }
        
    }
}
namespace Ingegneria_del_Software___QA.Tipi_in_.NET
{
    public class Esempi
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        public static void SplitCognomeNome(string cognomeNome, out string cognome, out string nome)
        {
            string[] words = cognomeNome.Split(' ');
            
            if (words.Length == 2)
            {
                cognome = words[0];
                nome = words[1];
            }
            else
            {
                cognome = "Unknown";
                nome = "Unknown";
            }
        }
        
        // Si supponga di dover scrivere:
        public void ProvaAdd()
        {
            int a = 1, b = 2, x1 = 1, x2 = 2, x3 = 3, x4 = 4;
            
            Add(a, b);  // a+b
            Add(10, 20, 30);    // 10+20+30
            Add(x1, x2, x3, x4);    // x1+x2+x3+x4
        }

        int Add(params int[] operands)
        {
            int total = 0;
            foreach (int operand in operands)
            {
                total += operand;
            }

            return total;
        }

        public void NoteAdd()
        {
            Add();  // restituisce 0

            int[] numbers = { 10, 20, 30, 40, 50 };
            Add(numbers);
            
            // equivalenti
            Add(new int[] {10, 20, 30, 40, 50});
            Add(10, 20, 30, 40, 50);
        }
    }

}
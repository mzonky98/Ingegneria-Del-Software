namespace Ingegneria_del_Software___QA.Esempi
{
    public class Esempi
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            T temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        public static void SplitCognomeNome(string cognomeNome, out string nome, out string cognome)
        {
            string[] words = cognomeNome.Split(' ');
            if (words.Length == 2)
            {
                cognome = words[0];
                nome = words[1];
            }
            else
            {
                cognome = "";
                nome = "";
            }
        }
        
        
        // -------
        public int Add(params int[] operands)
        {
            int total = 0;
            foreach (int operand in operands)
                total += operand;
            return total;
        }
    }
}   
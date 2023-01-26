namespace Ingegneria_del_Software___QA.Tipi_in_.NET
{
    public class Field
    {
        public const int MaxEntriesWrong = 100;
        public static readonly int MaxEntries = 100;
        
        /*  */
        /*
         * In the first case, the constant MaxEntries in injected into the Client code, and if
         * the value get changed from the Server also the Client assembly need to be recompiled
         *
         * In the second case, the MaxEntries value is somewhere in memory marked as "MaxEntries" and we need
         * find a way to access it. If the value changes in the Server, the Client assembly doesn't need to be
         * recompiled, because it's not bound to the inline injected value in the code
         *
         * NOTE: with the "static readonly" marker it's implied that the value of the variable is never granted
         * to be the same in different access. 
         */
    }
}
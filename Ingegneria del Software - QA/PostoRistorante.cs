namespace Ingegneria_del_Software___QA
{
    public class PostoRistorante
    {
        int _tableNumber;
        int _tableSeat;
        
        public PostoRistorante(int tableNumber, int tableSeat)
        {
            this._tableNumber = tableNumber;
            this._tableSeat = tableSeat;
        }

        public int TableSeat
        {
            get => _tableSeat;
            set => _tableSeat = value;
        }

        public int TableNumber
        {
            get => _tableNumber;
            set => _tableNumber = value;
        }

    }
}
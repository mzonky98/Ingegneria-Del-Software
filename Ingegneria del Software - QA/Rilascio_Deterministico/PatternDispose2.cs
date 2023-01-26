using System;

namespace Ingegneria_del_Software___QA.Rilascio_Deterministico
{
    public class PatternDispose2
    {
        public class Cursor
        {
            private Cursor _current;
            public Cursor Current
            {
                get => _current;
                set => _current = value;
            }
            
            private Cursor _waitCursor;
            public Cursor WaitCursor
            {
                get => new Cursor();
                set => _waitCursor = value;
            }
            
        }
        
        public class CursorReplacer : IDisposable
        {
            private readonly Cursor _previous;
            private readonly Cursor _original;

            public CursorReplacer(ref Cursor cursor)
            {
                _original = cursor; // Mi salvo l'originale (oggetto => per riferimento => modifiche avvengono sull'originale)
                _previous = cursor.Current; // Salvo il valore che attualmente è corrente
                cursor.Current = cursor.WaitCursor; // Impost come corrente il nuovo valore

            }
            public void Dispose()
            {
                _original.Current = _previous;  // Quando finisco rimetto il valore originale al cursore originale
            }
        }
    }
}
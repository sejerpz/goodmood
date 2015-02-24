using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    class WaitCursor : IDisposable
    {
        private Cursor previousCursor;
        private bool disposed = false;

        public WaitCursor()
            : this (Cursors.WaitCursor)
        {

        }

        public WaitCursor(Cursor cursor)
        {
            if (cursor == default(Cursor))
                cursor = Cursors.WaitCursor;

            previousCursor = Cursor.Current;
            Cursor.Current = cursor;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                Cursor.Current = previousCursor;
            }
        }
    }
}

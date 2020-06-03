using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class Iterator : IAbstractIterator
    {
        private Notebook notebook;
        private int currentPosition;
        private Box box;

        public Iterator(Notebook notebook)
        {
            this.notebook = notebook;
            this.currentPosition = 0;
        }

        public Iterator(Box box)
        {
            this.box = box;
        }

        public bool IsDone { get { return this.currentPosition >= this.notebook.Count; } }
        public Note Current { get { return this.notebook[this.currentPosition]; } }
        public Note First() { return this.notebook[0]; }
        public Note Next()
        {
            this.currentPosition++;
            if (this.IsDone)
            {
                return null;
            }
            else
            {
                return this.notebook[this.currentPosition];
            }
        }
    }
}

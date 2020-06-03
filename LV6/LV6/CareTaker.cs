using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class CareTaker
    {
        public Stack<Memento> PreviousStates = new Stack<Memento>();
        public void SetLast(Memento memento)
        {
            this.PreviousStates.Push(memento);
        }
        public Memento GetLast()
        {
            return this.PreviousStates.Pop();
        }
    }
}

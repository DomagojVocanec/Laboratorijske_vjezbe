using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}

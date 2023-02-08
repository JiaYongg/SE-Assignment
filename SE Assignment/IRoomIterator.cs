using System;
using System.Collections.Generic;
using System.Text;

namespace SE_Assignment
{
    public interface IRoomIterator
    {
        object Found();
        bool HasNext();
        void Remove();
    }
}

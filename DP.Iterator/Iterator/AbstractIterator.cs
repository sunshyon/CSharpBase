using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Iterator.Iterator
{
    /// <summary>
    /// 抽象迭代器：AbstractIterator
    /// </summary>
    public interface AbstractIterator
    {
        void Next();
        bool IsLast();
        void Previous();
        bool IsFirst();
        object GetNextItem();
        object GetPreviousItem();
    }
}

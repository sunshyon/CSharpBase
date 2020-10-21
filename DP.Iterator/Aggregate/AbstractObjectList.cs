using DP.Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Iterator.Aggregate
{
    /// <summary>
    /// 抽象聚合类：AbstractObjectList
    /// </summary>
    public abstract class AbstractObjectList
    {
        protected IList<object> objectList = new List<object>();
        public AbstractObjectList(IList<object> ol)
        {
            this.objectList = ol;
        }

        public void AddObject(object obj)
        {
            this.objectList.Add(obj);
        }
        public void RemoveObject(object obj)
        {
            this.objectList.Remove(obj);
        }
        public IList<object> GetObjectList()
        {
            return this.objectList;
        }

        public abstract AbstractIterator CreateIterator();
    }
}

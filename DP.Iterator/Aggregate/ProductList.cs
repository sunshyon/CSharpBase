using DP.Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Iterator.Aggregate
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ProductList : AbstractObjectList
    {
        public ProductList(IList<object>ol):base(ol)
        {
        }
        public override AbstractIterator CreateIterator()
        {
            return new ProductIterator(this);
        }

        private class ProductIterator : AbstractIterator
        {
            private ProductList productList;
            private IList<object> products;
            private int cursor1;// 定义一个游标，用于记录正向遍历的位置
            private int cursor2;// 定义一个游标，用于记录逆向遍历的位置

            public ProductIterator(ProductList pl)
            {
                this.productList = pl;
                this.products = productList.GetObjectList();
                this.cursor1 = 0;
                this.cursor2 = this.products.Count - 1;
            }
            public object GetNextItem()
            {
                return products[cursor1];
            }

            public object GetPreviousItem()
            {
                return products[cursor2];
            }

            public bool IsFirst()
            {
                return cursor2 == -1;
            }

            public bool IsLast()
            {
                return cursor1 == products.Count;
            }

            public void Next()
            {
                if (cursor1 < products.Count)
                {
                    cursor1++;
                }
            }

            public void Previous()
            {
                if (cursor2 > -1)
                {
                    cursor2--;
                }
            }
        }
    }
}

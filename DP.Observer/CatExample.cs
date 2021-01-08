using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Observer
{
    /// <summary>
    /// 事件是实现观察者的优雅方式
    /// </summary>

    public class Test
    {
        public static void Start()
        {
            var cat = new Cat();
            cat.CatMiaoHandler += new Dog().Wang;
            cat.CatMiaoHandler += new Chicken().GeGeGe;
            cat.Miao();
        } 
    }
    public class Cat
    {
        public event Action CatMiaoHandler;
        public void Miao()
        {
            Console.WriteLine("Cat 'Miao!'");
            this.CatMiaoHandler?.Invoke();
        }
    }
    public class Dog
    {
        public void Wang()
        {
            Console.WriteLine("Dog 'Wang!'");
        }
    }
    public class Chicken
    {
        public void GeGeGe()
        {
            Console.WriteLine("Chicken 'GeGeGe!'");
        }
    }
}

using System;
using Utility;

namespace A.Fuck
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIsPalindrome();
            //TestLinkList();
        }
        static void TestIsPalindrome()
        {
            var str = "ABCBA1";
            var res = new StringRelated().IsPalindrome(str);
        }
        static void TestLinkList()
        {
            var ll = new LinkList();
            ll.TestReverse();
        }
        static void TestFib()
        {
            CodeTimerHelper.Time("Fib", 1, () => {
                //var a = new DynamicPlan().Fib(40);
                //var a = TestFib(40);
                var a = new DynamicPlan().Fib3(40);
                Console.WriteLine(a);
            });
        }
    }
}

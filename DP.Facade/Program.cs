using DP.Facade.Facade;
using System;

namespace DP.Facade
{
    /// <summary>
    /// 外观模式
    /// https://www.cnblogs.com/edisonchou/p/7124069.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFacade facade = new EncryptFacade();
            if (facade != null)
            {
                facade.FileEncrypt("Facade/src.txt", "Facade/des.txt");
            }
        }
    }
}

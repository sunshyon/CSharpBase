using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Facade.Facade
{
    /// <summary>
    /// 抽象外观类
    /// </summary>
    public abstract class AbstractFacade
    {
        /// <summary>
        /// 定义抽象方法，将子系统的操作统一实现
        /// </summary>
        public abstract void FileEncrypt(string fileNameSrc, string fileNameDes);
    }
}

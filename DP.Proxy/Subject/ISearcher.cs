using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Proxy.Subject
{
    /// <summary>
    /// 抽象主题类：抽象查询接口
    /// </summary>
    public interface ISearcher
    {
        string DoSearch(string uId, string key);
    }
}

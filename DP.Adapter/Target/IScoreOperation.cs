using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Adapter.Target
{
    /// <summary>
    /// 目标抽象类
    /// </summary>
    public interface IScoreOperation
    {
        //成绩排序
        void Sort(int[] array);

        //成绩查询
        int Search(int[] array, int key);
    }
}

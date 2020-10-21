using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 文件夹类：容器构件，组合模式体现处
    /// </summary>
    public class Folder:AbstractFile
    {
        private string name;

        //private IList<Folder> folderList = new List<Folder>();
        //private IList<ImageFile> imageList = new List<ImageFile>();
        //private IList<TextFile> textList = new List<TextFile>();

        /// <summary>
        /// 将以上三种组合成一个集合
        /// </summary>
        private IList<AbstractFile> fileList = new List<AbstractFile>();

        public Folder(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile f)
        {
            fileList.Add(f);
        }
        public override void Remove(AbstractFile f)
        {
            fileList.Remove(f);
        }
        public override AbstractFile GetChild(int index)
        {
            return fileList[index];
        }

        public override void KillVirus()
        {
            //Console.WriteLine("**** 对文件夹'{0}'进行杀毒", name);
            //foreach (var item in folderList)
            //{
            //    item.KillVirus();
            //}
            //foreach (var item in imageList)
            //{
            //    item.KillVirus();
            //}
            //foreach (var item in textList)
            //{
            //    item.KillVirus();
            //}

            // 此处模拟杀毒操作
            Console.WriteLine("---- 对文件夹‘{0}’进行杀毒", name);

            foreach (var item in fileList)
            {
                item.KillVirus();
            }
        }
    }
}

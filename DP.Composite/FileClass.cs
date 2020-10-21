﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 叶子构件：图像文件、文本文件 和 视频文件
    /// </summary>
    public class ImageFile:AbstractFile
    {
        private string name;
        public ImageFile(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }
        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }
        public override AbstractFile GetChild(int index)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
            return null;
        }
        public override void KillVirus()
        {
            Console.WriteLine($"---- 对图像文件‘{name}’进行杀毒");
        }
    }
    public class TextFile: AbstractFile
    {
        private string name;
        public TextFile(string name)
        {
            this.name = name;
        }
        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }

        public override AbstractFile GetChild(int index)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
            return null;
        }
        public override void KillVirus()
        {
            Console.WriteLine($"---- 对文本文件‘{name}’进行杀毒");
        }
    }
    public class VideoFile : AbstractFile
    {
        private string name;

        public VideoFile(string name)
        {
            this.name = name;
        }

        public override void Add(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }

        public override void Remove(AbstractFile file)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
        }

        public override AbstractFile GetChild(int index)
        {
            Console.WriteLine("对不起，系统不支持该方法！");
            return null;
        }

        public override void KillVirus()
        {
            // 此处模拟杀毒操作
            Console.WriteLine("**** 对视频文件‘{0}’进行杀毒", name);
        }
    }
}

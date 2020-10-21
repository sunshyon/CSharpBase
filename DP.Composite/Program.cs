using System;

namespace Composite
{
    /// <summary>
    /// 组合模式
    /// https://www.cnblogs.com/edisonchou/p/7082904.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFile folder1 = new Folder("EDC的资料");
            AbstractFile folder2 = new Folder("图像文件");
            AbstractFile folder3 = new Folder("文本文件");
            AbstractFile folder4 = new Folder("视频文件");

            AbstractFile image1 = new ImageFile("小龙女.jpg");
            AbstractFile image2 = new ImageFile("张无忌.gif");

            AbstractFile text1 = new TextFile("九阴真经.txt");
            AbstractFile text2 = new TextFile("葵花宝典.doc");

            AbstractFile video1 = new VideoFile("笑傲江湖.rmvb");
            AbstractFile video2 = new VideoFile("天龙八部.mp4");

            folder2.Add(image1);
            folder2.Add(image2);

            folder3.Add(text1);
            folder3.Add(text2);

            folder4.Add(video1);
            folder4.Add(video2);

            folder1.Add(folder2);
            folder1.Add(folder3);
            folder1.Add(folder4);

            folder1.KillVirus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using libDxRec;

namespace TestRec
{
    class Program
    {
        static void Main(string[] args)
        {
            Recoder recoder = new Recoder();
            recoder.SetFileName("D://rec.wav");
            Console.WriteLine("现在开始录制，按回车结束录制");
            recoder.RecStart();
            Console.Read();
            recoder.RecStop();
        }
    }
}

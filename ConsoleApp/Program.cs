using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteFormatedTime();
            Classic.Runner.Run();
            //WriteFormatedTime();
            Delegate.Runner.Run();
            //WriteFormatedTime();
            DotNet.Runner.Run();
            //WriteFormatedTime();
        }

        //private static void WriteFormatedTime()
        //{
        //    Console.WriteLine(DateTime.Now.Second + "." + DateTime.Now.Millisecond);
        //}
    }
}

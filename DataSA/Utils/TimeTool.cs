using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace DataSA.Utils
{
    public static class TimeTool
    {
        public interface ITask
        {
            void execute();
        }

        public static void check(string title, Func<int, int> action, int num)
        {
            if (action == null) return;
            title = (title == null) ? "" : ("【" + title + "】");
            Stopwatch watch = new Stopwatch();
            Console.WriteLine(title);

            Console.WriteLine($"开始{DateTime.Now}");
            
            watch.Start();
            Console.WriteLine($"输出D：{action.Invoke(num)}"); ;
            watch.Stop();

            Console.WriteLine($"结束{DateTime.Now}");



            Console.WriteLine($"耗时{watch.Elapsed}");
            Console.WriteLine("=============================================");
        }
    }
}

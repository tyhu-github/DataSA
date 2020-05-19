using System;

namespace _01_复杂度
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 斐波那契数列
            while (true)
            {
                Console.WriteLine("请输入值：");
                int n = int.Parse(Console.ReadLine());

                TimeTool.check("递归法", FBNQ.FibByDG, n);
                TimeTool.check("计算法", FBNQ.FibByJS, n);
                TimeTool.check("简化法", FBNQ.FibByJH, n);
                TimeTool.check("线性法", FBNQ.FibByXX, n);
                TimeTool.check("矩阵法", FBNQ.FibByJZ, n);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataSA
{
    /// <summary>
    /// 斐波那契数列
    /// </summary>
    public static class FBNQ
    {
        /// <summary>
        /// 斐波那契（递归） 0 1 1 2 3 5  8 13
        /// 
        /// 时间复杂度 O(2^n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibByDG(int n)
        {
            if (n <= 1) return n;
            return FibByDG(n - 1) + FibByDG(n - 2);
        }

        /// <summary>
        /// 对应的n          0 1 2 3 4 5 6 7  8  9  10
        /// 斐波那契（计算） 0 1 1 2 3 5 8 13 21 34 55
        /// 效率远远大于递归方法
        /// 时间复杂度 O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibByJS(int n)
        {
            if (n <= 1) return n;
            int first = 0;
            int second = 1;
            //int sum = 0;
            for(int i = 0;i < n - 1; i++)
            {
                int sum = first + second;
                first = second;
                second = sum;
            }
            //return sum;
            return second;
        }

        /// <summary>
        /// 斐波那契（简化） 0 1 1 2 3 5 8 13 21 34 55
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibByJH(int n)
        {
            if (n <= 1) return n; 
            int first = 0;
            int second = 1;
            while (n -- > 1)
            {
                second += first;
                first = second - first;
            }
            return second;
        }

        /// <summary>
        /// 斐波那契（线性代数解法） 0 1 1 2 3 5 8 13 21 34 55
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibByXX(int n)
        {
            double c = Math.Sqrt(5);
            return (int)((Math.Pow((1 + c) / 2, n) - Math.Pow((1 - c) / 2, n)) / c);
            //return (int)(1 / c * (Math.Pow((1 + c) / 2, n) - Math.Pow((1 - c) / 2, n)));
        }

        /// <summary>
        /// 矩阵法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibByJZ(int n)
        {
            ulong[,] a = new ulong[2, 2] { { 1, 1 }, { 1, 0 } };
            ulong[,] b = MatirxPower(a, n);
            return (int)b[1, 0];
        }

        #region FibByJZ
        static ulong[,] MatirxPower(ulong[,] a, int n)
        {
            if (n == 1) { return a; }
            else if (n == 2) { return MatirxMultiplication(a, a); }
            else if (n % 2 == 0)
            {
                ulong[,] temp = MatirxPower(a, n / 2);
                return MatirxMultiplication(temp, temp);
            }
            else
            {
                ulong[,] temp = MatirxPower(a, n / 2);
                return MatirxMultiplication(MatirxMultiplication(temp, temp), a);
            }
        }

        static ulong[,] MatirxMultiplication(ulong[,] a, ulong[,] b)
        {
            ulong[,] c = new ulong[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }
        #endregion
    }
}

using _02_动态数组;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. 斐波那契数列
            //while (true)
            //{
            //    Console.WriteLine("请输入值：");
            //    int n = int.Parse(Console.ReadLine());

            //    TimeTool.check("递归法", FBNQ.FibByDG, n);
            //    TimeTool.check("计算法", FBNQ.FibByJS, n);
            //    TimeTool.check("简化法", FBNQ.FibByJH, n);
            //    TimeTool.check("线性法", FBNQ.FibByXX, n);
            //    TimeTool.check("矩阵法", FBNQ.FibByJZ, n);
            //}

            ////2. 动态数组
            //DynamicArray list = new DynamicArray();

            //Console.WriteLine(list.Size());
            //list.Add(00);
            //list.Add(11);
            //list.Add(22);
            //list.Add(33);
            //list.Add(44);
            //list.Add(55);
            //list.Add(66);
            //Console.WriteLine(list);

            //list.Remove(2);
            //Console.WriteLine(list);

            //list.Add(2,22);
            //Console.WriteLine(list);

            //Console.WriteLine(list.Set(2, 33));
            //Console.WriteLine(list);

            //Console.WriteLine(list.IndexOf(33));


            ////3. 动态泛型数组
            //ArrayList<People> persons = new ArrayList<People>();
            //persons.Add(new People(10, "Jack"));
            //persons.Add(null);
            //persons.Add(new People(12, "James"));
            //persons.Add(new People(15, "Rose"));
            //Console.WriteLine(persons);

            //Console.WriteLine(persons.IndexOf(null));

            //persons.Clean();
            //Console.WriteLine(persons);

            //Console.ReadKey();

            var intArray = new int[] { 1, 3, 5, 7 };

            IEnumerator enumerator = intArray.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }


            var intList = new List<int>() { 2, 4, 6, 8 };

            IEnumerator enumerator2 = intList.GetEnumerator();

            while (enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }
        }
    }
}

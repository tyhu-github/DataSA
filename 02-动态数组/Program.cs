using System;

namespace _02_动态数组
{
    class Program
    {
        static void Main(string[] args)
        {
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


            //3. 动态泛型数组
            ArrayList<People> persons = new ArrayList<People>();
            persons.Add(new People(10, "Jack"));
            persons.Add(null);
            persons.Add(new People(12, "James"));
            persons.Add(new People(15, "Rose"));
            Console.WriteLine(persons);

            Console.WriteLine(persons.IndexOf(null));

            persons.Clean();
            Console.WriteLine(persons);

            Console.ReadKey();
        }
    }
}

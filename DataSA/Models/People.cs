using System;
using System.Collections.Generic;
using System.Text;

namespace _02_动态数组
{
    public class People
    {
        private int age;
        private string name;

        public People(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Person [age={age}, name={name}]";
        }

        public override bool Equals(object obj)
        {
            People person = obj as People;
            return this.age == person.age;
        }
    }
}

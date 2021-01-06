using System;
using System.Collections.Generic;
using System.Text;

namespace dotCoreConsole1
{
    abstract class Animal
    {
        public int Age { get; set; } = 1;

        public string Name { get;set; } = "Animal";

        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }

        //public static Animal CreateAnimal(int age,string name)
        //{
        //    return new Animal(age, name);
        //}

        public abstract void Eat();

        public virtual void SayIt()
        {
            Console.WriteLine($"Say It from Animal. 年龄：{Age} | 名字: {Name}");
        }

        public static void Jump()
        {
            Console.WriteLine("Jumped!");
        }
    }
}

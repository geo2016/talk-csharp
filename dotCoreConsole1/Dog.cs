using System;
using System.Collections.Generic;
using System.Text;

namespace dotCoreConsole1
{
    class Dog : Animal, IRun
    {
        public Dog(int age, string name, string description) : base(age, name)
        {

        }

        public int Speed => 50;

        public override void Eat()
        {
            Console.WriteLine("Eat Bone");
        }

        public void Run()
        {
            Console.WriteLine($"Dog Running at {Speed}");
        }

        public override void SayIt()
        {
            Console.WriteLine($"汪汪。。。. 年龄：{Age} | 名字: {Name}");
        }

        public void CatchABall()
        {
            Console.WriteLine("The dog is catching a ball.");
        }
    }
}

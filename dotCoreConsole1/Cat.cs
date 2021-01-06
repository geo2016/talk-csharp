using System;
using System.Collections.Generic;
using System.Text;

namespace dotCoreConsole1
{
    class Cat:Animal,IMouseHunter
    {
        public Cat(int age, string name, string description) : base(age, name)
        {
        }



        public int Speed => 30;

        public void CatchMouse()
        {
            Console.WriteLine("Cat is Mouse Hunter");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat Fish");
        }

        public void Run()
        {
            Console.WriteLine($@"Cat Running
            at {Speed}");
        }

        public override void SayIt()
        {
            Console.WriteLine($"喵喵。。。. 年龄：{Age} | 名字: {Name}");
        }
    }
}

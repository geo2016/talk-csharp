using System;
using System.Diagnostics;

namespace dotCoreConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = Animal.CreateAnimal(5,"Cat");

            //animal.Age = 3;
            //animal.Name = "Dog";
            //Animal animal = new Animal() { Age = 4, Name = "Elephont" };

            //animal.SayIt();

            //Animal.Jump();

            /*
            Cat cat = new Cat(2,"Cat","It is a lovely Cat"); 
            cat.SayIt();
            cat.Run();

            IRun runObj = cat;
            runObj.Run();

            */

            Animal animal1 = new Cat(2, "Cat", "It is a lovely Cat");
            if (animal1 is IMouseHunter catObj)
            {
                catObj.CatchMouse();
                catObj.job1();
            }

            

            //Cat cat1 = new Cat(2, "Cat", "It is a lovely Cat");
            //cat1.Run();

            /*
            IRun[] arrInfRun =
            {
                new Dog(3,"Dog","It is a brave Dog."),
                new Cat(2,"Cat","It is a lovely Cat")
            };


            foreach (var item in arrInfRun)
            {
                item.Run();

                if(item is Dog dog)
                {//类型转换安全的。返回true
                    dog.CatchABall();
                }

                //Dog dog1 = item as Dog;
                //if (dog1 != null)
                //{
                //    dog1.CatchABall();
                //}
            }
            */







            //TestVarType();
            //return;

            /*
            int loop = 0;
            while (loop<10)
            {
                Console.WriteLine($"loop value is {loop}");
                loop++;
            }
            */

            //Debug.WriteLine("调试输出内容");


            //Console.Error.WriteLine("错误信息");




            /*
            int i1 = 10, i2 = 10;

            int r1 = i1 / i2;

            Console.WriteLine($"{i1} / {i2}的计算结果是 {r1}");
            */

            /*
            Car1 car1 = new Car1();

            car1.Say1();

            car1.ChangeMyTitle("Red Name");
            car1.Say1();
            Console.WriteLine("Hello 2021!");
            */
        }


        enum Month : byte
        {
            January=0,
            February,
            March,
        }

        /// <summary>
        /// 学习变量类型
        /// </summary>
        private static void TestVarType()
        {
            // float:32 double:64 Decimal:128

            //short j1 = 200;

            //int i1 = 1000;
            //short j2 = (short)i1;

            //int i2;
            //int i3 = i2 + 1;

            string s1 = "aaa";
            string s2 = s1;
            s1 = "bbb"; // s1=new string("bbb")

            // 引用类型

            object o1 = "ddd";
            string s3 = o1 as string; // is

            // 内存回收
            // C# IL, CLR,JIT
            // 引用变量过了作用范围，=null CLR会有一个引用计数

            //Array List
            
        }
    }
}

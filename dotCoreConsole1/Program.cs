using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace dotCoreConsole1
{
    class Program
    {
        enum tagScoreLevel
        {
            Low=0,
            Good=80,
        }

        static void Main(string[] args)
        {
            // DataTables

            // Dictionary
            Dictionary<string, string> animalFood = new Dictionary<string, string>();

            

            animalFood.Add("Dog", "Bone,Meat");
            animalFood["Cat"] = "Fish";

            //string food = animalFood["Wolf"];
            if(animalFood.TryGetValue("Wolf",out string food))
            {

            }

            if (animalFood.ContainsKey("Wolf"))
            {
                string food2 = animalFood["Wolf"];
            }

            // List
            string animals = "Dog,Cat,Elephont";
            string[] arr1 = animals.Split(',');

            List<string> list1 = new List<string>(arr1);

            list1.Add("Wolf");
            list1.Insert(0, "Fox");

            string[] arr4 = { "Bird", "Mouse" };
            list1.AddRange(arr4);

            list1.Remove("Dog");

            // - 排序
            //list1.Sort();

            //list1.Sort((x, y) => x.Length < y.Length ? -1 : 1);
            list1.Sort((x, y) => x.Length.CompareTo(y.Length));

            string[] arr3 = list1.ToArray();

            List<string> list2 = list1.FindAll(x => x.Length == 4);
            list1.RemoveAll(x => x.Length == 4);




            // Array

            foreach (string item in arr1)
            {
                Console.WriteLine(item);
            }

            string[] arr2 = 
            {
                "111",
                "2222",
            };

            

            // Enum
            int score = (int)Enum.Parse(typeof(tagScoreLevel), "Good");

            Console.WriteLine("输入您的考试分数：");
            if(int.TryParse(Console.ReadLine(),out int iScore))
            {
                tagScoreLevel level1 = tagScoreLevel.Low;

                if (iScore >= (int)tagScoreLevel.Good)
                {
                    level1 = tagScoreLevel.Good;
                }

                //switch (level1)
                //{
                //    case tagScoreLevel.Low:
                //        break;

                //    case tagScoreLevel.Good:
                //        break;

                //    default:
                //        break;
                //}
                Console.WriteLine("您的表现："+level1.ToString());
            }

            













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

            /*
            Animal animal1 = new Cat(2, "Cat", "It is a lovely Cat");
            if (animal1 is IMouseHunter catObj)
            {
                catObj.CatchMouse();
                catObj.job1();
            }

            

            //Cat cat1 = new Cat(2, "Cat", "It is a lovely Cat");
            //cat1.Run();

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

using System;
using System.Collections.Generic;
using System.Linq;//类似Javascript Prototype

namespace ConsoleAppLinq
{
    class Program
    {
        // a+b
        static Func<int,int, int> add = delegate (int a,int b)
        {
            return a + b;
        };


        // Func 表示有返回值
        static Func<int, int, int> add2 = (a, b) => a + b;

        // Action 没有返回值
        static Action print1 = () => Console.WriteLine("print1 called");
        static Action<string> print2 = x =>
        {
            Console.WriteLine("print2 called");
            Console.WriteLine($"Hello {x}");
        };

        enum tagScoreLevel
        {
            Low = 0,
            Good = 80,
        }

        static void Main(string[] args)
        {
            // 让 Switch更加直观
            tagScoreLevel level1 = tagScoreLevel.Good;
            string disp = "";
            /*
            switch (level1)
            {
                case tagScoreLevel.Low:
                    disp = "不行啊";
                    break;
                case tagScoreLevel.Good:
                    disp = "挺不错";
                    break;
                default:
                    disp = "unknown";
                    break;
            }
            */

            disp = level1 switch
            {
                tagScoreLevel.Low => "不行啊",
                tagScoreLevel.Good => "挺不错",
                _ => "unknown",
            };

            Console.WriteLine(disp);



            // 方法代替LINQ表达式
            //int[] numbers = new[] { 1, 34, 67, 92,87,78,55, 100, 23, 87 };

            //var r1 = numbers.Where(x => x > 50 && x < 80)
            //    .OrderBy(x => x)
            //    .Select(a => $"data is {a}, +100 = {a + 100}");

            

            //var result =
            //    from a in numbers // 数据源
            //    where (a > 50 && a < 80) // 条件
            //    orderby a ascending //排序
            //    select $"data is {a}, +100 = {a + 100}"; //返回 可以格式化，自定义计算

            //foreach (var item in r1)
            //{
            //    Console.WriteLine(item);
            //}


            /*

            print1();

            print2("ddd");

            // Lambda 源自委托方法，匿名函数
            Console.WriteLine($"{add(2,7)}");
            Console.WriteLine($"{add2(2,1)}");







            var animals = new[]
            {
                new{Name="Dog",Age=3,Type1="Home"},
                new{Name="Cat",Age=1,Type1="Home"},
                new{Name="Fox",Age=1,Type1="Wild"},
                new{Name="Wolf",Age=2,Type1="Wild"},
                new{Name="Monkey",Age=5,Type1="Wild"},
            };

            var foods = new[]
            {
                new {Name="Dog",Food="Bone,Meat"},
                new {Name="Cat",Food="Fish"},
                new {Name="Wolf",Food="Meat"},
                new {Name="Monkey",Food="Banana,Apple"},
            };

            var sounds = new[]
            {
                new {Name="Dog",Sound="汪汪"},
                new {Name="Cat",Sound="喵喵"},
                new {Name="Wolf",Sound="喔喔"},
                new {Name="Monkey",Sound="hi hi"},
            };

            var animalFood =
                from a in animals
                join f in foods //join .. in
                on a.Name equals f.Name // on ... equals
                join s in sounds //join .. in
                on a.Name equals s.Name // on ... equals
                orderby a.Name//排序字段
                select $"{a.Name} like {f.Food}. {s.Sound}";//返回值

            var result =
                from a in animalFood
                select $"123 {a}";

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            */


            /*

            // 方法名来调用分组
            var r1 = animals.GroupBy(a => a.Type1);//没有LINQ查询代码直观，灵活。
            foreach (var item in r1)
            {
                Console.WriteLine($"分类：{item.Key}");

                foreach (var x in item)
                {
                    Console.WriteLine(x);
                }
            }

            // 查询分组
            var result =
                from a in animals
                    //where a.Age>2
                group a by a.Type1 into grp
                //where grp.Count() > 2
                orderby grp.Count() descending
                select new
                {
                    Type = grp.Key,
                    Count = grp.Count(),
                };

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }





            foreach (var item in result)
            {
                Console.WriteLine($"分类：{item.Key}");

                foreach (var x in item)
                {
                    Console.WriteLine(x);
                }
            }

            var result =
                from a in animals
                group a by a.Type1;
            foreach (var item in result)
            {
                Console.WriteLine($"分类：{item.Key}");

                foreach (var x in item)
                {
                    Console.WriteLine(x);
                }
            }
            */










            /*

            var result =
                from a in animals
                where a.Type1 == "Wild"
                orderby a.Age descending
                select $"{a.Name},Age {a.Age}";

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            // Group, join

            /*

            int[] numbers = new[] { 1, 34, 67, 92, 100, 23, 87 };

            // var 编译的时候会自动识别类型
            var result =
                from a in numbers // 数据源
                where (a > 50 && a<80) // 条件
                orderby a ascending //排序
                select $"data is {a}, add 100 = {a+100}"; //返回 可以格式化，自定义计算

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"平均值：{numbers.Take(2).Average():F2}");

            IEnumerable<int> result = numbers.Take(3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;//类似Javascript Prototype

namespace ConsoleAppLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new[]
            {
                new{Name="Dog",Age=3,Type1="Home"},
                new{Name="Cat",Age=1,Type1="Home"},
                new{Name="Wolf",Age=2,Type1="Wild"},
                new{Name="Monkey",Age=5,Type1="Wild"},
            };

            var result =
                from a in animals
                where a.Type1 == "Wild"
                orderby a.Age descending
                select $"{a.Name},Age {a.Age}";

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ConsoleAppReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = "t1.txt";

            // Json序列化对象
            var foods = new[]
            {
                new {Name="Dog",Food="Bone,Meat"},
                new {Name="Cat",Food="Fish"},
                new {Name="Wolf",Food="Meat"},
                new {Name="Monkey",Food="Banana,Apple"},
            };

            // 读取json
            string text1 = File.ReadAllText(file1);
            var data = JsonSerializer.Deserialize<List<dynamic>>(text1);// 反序列化，这里需要指定类型。 匿名类型反序列化用dynamic
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            /*

            // 写入json
            var jsonStr = JsonSerializer.Serialize(foods);
            File.WriteAllText(file1, jsonStr);


            // 字符编码
            string line1 = "Hello 2021";//字符串 由字符构成

            foreach (char c1 in line1)
            {
                // 每个字符 有不同的编码来定义，通常对应一个数字。 UTF-8编码，对应1-4个字节
                byte b1 = (byte)c1;

                Console.WriteLine($"{c1} -> {Convert.ToString(b1,2).PadLeft(8,'0')} -> {b1} -> {b1:X}");
            }





            // 静态方法，里面会自动打开、关闭。
            string s1 = File.ReadAllText(file1);
            Console.WriteLine(s1);


            // 内存数据写入 通常用于转换数据格式或者协议网关实现等场景
            using (var ms = new MemoryStream())
            {
                using (var sw = new StreamWriter(ms))
                {
                    // Stream - > 另一个Stream对象
                    sw.WriteLine("Hello 2021");
                }

                // 打印出来
                var bb = ms.ToArray();

                string s1 = Encoding.UTF8.GetString(bb);
            }

            // 读取文件
            using (var sr = new StreamReader(file1))
            {// 代码执行结束后，会自动调用这个对象的IDisposable接口，释放资源。
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }

            }
            */


            /*
            // 写入文件
            var sw = new StreamWriter(file1);

            sw.WriteLine("ddd");
            //sw.Flush();

            sw.Close();//记得关闭。 否则，文件会一直占用。同时写入数据并不一定完成。

            */

        }
    }
}

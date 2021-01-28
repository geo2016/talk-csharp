using System;
using System.Drawing;



// 类型推断

var pt = new Point(1,2);
Point pt2 = new(2, 4);

Girl girl1 = new("Kate", 15);
Console.WriteLine(girl1);

// is not
//if(!(girl1 is Girl))
if(girl1 is not Girl)
{
    Console.WriteLine("是一个女孩");
}



public record Girl(string Name, int Age)
{
    public string Food { get; init; } = "Rice";
}













//// Pattern matching enhancements
//int weight = 49;
//string descript = getWeightDescript(weight,"女");
//Console.WriteLine($"体重{weight}Kg {descript}");

///// <summary>
///// 根据体重得到描述文字
///// </summary>
//static string getWeightDescript(int weight,string sex="男")
//{
//    return (sex,weight) switch
//    {
//        ("男", < 60 or > 200) => "不可能",
//        ("女", < 50 or > 180) => "不可能",
//        ("男", <= 70 and not 66) => "正好啊",
//        ("男", <= 90) => "有点胖了",
//        ("男", < 100 and > 90) => "肥胖",
//        _ => "未知",
//    };
//}


















//Console.WriteLine($"command argument: {args}");






//Boy boy1 = new Boy("John", 13)
//{
//    Food = "Cake",
//};

//// With
//Boy boy2 = boy1 with { Name = "Tim", Food = "Fish" };

//Boy boy3 = new Boy("John", 13)
//{
//    Food = "Cake",
//};

//if(boy1 == boy2)
//{
//    Console.WriteLine("is Same");
//}

////boy1.Name = "";

//Console.WriteLine(boy1);
//Console.WriteLine(boy2);

//public record Boy(string Name,int Age)
//{
//    public string Food { get; init; } = "Rice";
//}


// init 类似实现方式
//class Girl
//{
//    private readonly int _age;

//    Girl(int age)
//    {
//        _age = age;
//    }

//    public int Age
//    {
//        get { return _age; }
//        //set { _age = value; }
//    }

//}

//public record Boy()
//{
//    public string Name { get; init; } = "Tim";
//    public int Age { get; init; }
//}

//sayIt();

//static void sayIt()
//{
//    Console.WriteLine("Hi C sharp 9");
//}
using System;
using System.Collections.Generic;
using System.Text;

namespace dotCoreConsole1
{
    interface IMouseHunter:IRun
    {
        void CatchMouse();


        void job1()
        {
            Console.WriteLine(@"Animal animal1 = new Cat(2, ""Cat"", ""It is a lovely Cat"");
            if (animal1 is IMouseHunter catObj)
            {
                catObj.CatchMouse();
                catObj.job1();
            }
            ");
        }
    }
}

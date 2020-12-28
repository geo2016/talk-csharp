using System;
using System.Collections.Generic;
using System.Text;

namespace dotCoreConsole1
{
    class Car1
    {
        private string _title;

        public Car1()
        {
            _title = "No Name";
        }
        /// <summary>
        /// 说一下自己的名字
        /// </summary>
        public void Say1()
        {
            Console.WriteLine($"I'm a {_title}.");
        }

        public void ChangeMyTitle(string newTitle)
        {
            _title = newTitle;
        }
    }
}

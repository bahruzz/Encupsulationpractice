using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Bird:Animal
    {
        public string Color { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird sound");
        }
        public override void Test()
        {
            Console.WriteLine("Tested");
        }

    }
}

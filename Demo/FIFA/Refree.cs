using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.FIFA
{
    internal class Refree
    {
        public string name { get; set; }
        public void look(Ball ball)
        {
            Console.WriteLine($"Refree {name} is looking at ball: {ball}");
        }
        public override string ToString()
        {
            return $"Refree Name : {name}";
        }
    }
}

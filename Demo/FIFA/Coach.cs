using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.FIFA
{
    internal class Coach
    {
        public string name { get; set; }
        public string teamName { get; set; }
        public void Order(Ball ball)
        {
            Console.WriteLine($"Player {name} is running ...at {ball} ");
        }
        public override string ToString()
        {
            return $" Player Name : {name} , Team Name : {teamName} ";
        }
    }
}

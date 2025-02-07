using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class Subscribers
    {
        public string Name { get; set; }
        public void Notify(Channel channel , video video)
        {
            Console.WriteLine($"Channel: {channel.Title} is add Video: {video} to you {Name}");
        }
        public override string ToString()
        {
            return $"Subscriber Name : {Name}";
        }
    }
}

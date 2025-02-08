using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Youtube
{
    internal class video
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Video Title: {Title} , Video Description: {Description}";
        }
    }
}

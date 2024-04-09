using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    struct Coordinate
    {
        public int x { get; set; } 
        public int y { get; set; }

        public Coordinate()
        {
            
        }
        public Coordinate(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        static Coordinate()
        {
            Console.WriteLine("Static ise dusdu");
        }
        public override string ToString()
        {
            return "X:"+ x+",Y:"+y;
        }
    }
}

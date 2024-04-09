using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    public struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ClothesSize ClothesSize { get; set; }

        public override string ToString()
        {
            return "Id: " + this.Id+ " Name: " + this.Name + " Surname:" + this.Surname + " Size:" + this.ClothesSize;
        }
    }
}

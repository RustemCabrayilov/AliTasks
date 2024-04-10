using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnum
{
    public struct Employee
    {
        private readonly int _id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public ClothesSize ClothesSize { get; set; }

        private static int _count;

        public Employee()
        {
            _count++;
            _id = _count;
        }

        public override string ToString()
        {
            return "Id: " + this._id+ " Name: " + this.Name + " Surname:" + this.Surname + " Size:" + this.ClothesSize;
        }
    }
}

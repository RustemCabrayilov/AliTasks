using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Models
{
	public abstract class Person
	{
		public int Id { get; set; }
		public string Name { get; set;}
		public  string Surname { get; set;}
		public string Address { get; set;}
		public int Age { get; set;}
        
        public Person()
        {
            
        }
        // Abstract methodun icini hecne yazilmir. Miras verdiyimiz classslarda bu method override olunur ve hemin miras verdiyimiz classlarda methodun daxili yazilir
        public abstract void Eating();

        //Virtual methodu istesek override eliye bilerik. Eger override etmesek gedir base classdaki hemin methodu ise salir
        public virtual void Running()
        {
            Console.WriteLine("Running method isledi");
        }

   
    }
}

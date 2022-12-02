using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_H.Models
{
	public class Room
	{
		private static int _counter;
		public int Id { get; }
		public string Name { get; set; }
		public double Price { get; set; }
		public int PersonCapacity { get; set; }
		public bool IsAvialable { get; set; }

		public Room(string name, double price, int personCapacity)
		{
			_counter++;
			this.Id = _counter;
			this.Name = name;
			this.Price = price;
			this.PersonCapacity = personCapacity;
			this.IsAvialable = true;
		}

		public override string ToString()
		{
			 return ShowInfo();
		}

		public string ShowInfo()
		{
			return ($"Id: {this.Id}, Name: {this.Name}, Price: {this.Price}, PersonCapacity: {this.PersonCapacity}");
		}
	}
}

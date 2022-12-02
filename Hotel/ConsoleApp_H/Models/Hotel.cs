using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_H.Models
{
	internal class Hotel
	{
		public string Name { get; set; }
		public Room[] rooms = new Room[0];

		public Hotel(string name)
		{
			this.Name = name;
			
		}

		public void AddRoom(Room room)
		{
			Array.Resize(ref rooms, rooms.Length+1);
			rooms[^1] = room;
		}



		public void MakeReservation(int? id)
		{
			if (id.HasValue)
			{
				foreach (var item in rooms)
				{
					if (item.Id == id)
					{
						if (item.IsAvialable == true)
						{
							item.IsAvialable = false;
							Console.WriteLine("Otaq rezerv olundu");
						}
						else
						{
							throw new NotAviableException("Otaq doludur!");
						}
					}
				}
			}
			else
			{
				throw new NullReferenceException("Bos deyer gonderildi!");
			}
		}
	}
}

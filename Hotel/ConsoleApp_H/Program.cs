using ConsoleApp_H.Models;

namespace ConsoleApp_H
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Room room = new Room("room1",56.5,6);
			Room room2 = new Room("room2",56.5,6);

			Hotel hotel = new Hotel("Hilton");
			hotel.AddRoom(room);
			hotel.AddRoom(room2);
			foreach (var item in hotel.rooms)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine(room);
			try
			{
				hotel.MakeReservation(2);

				hotel.MakeReservation(1);
			}
			catch (NotAviableException e)
			{

				Console.WriteLine(e.Message);
			}
			catch (NullReferenceException e)
			{
				Console.WriteLine(e.Message);
			}


		}
	}
}
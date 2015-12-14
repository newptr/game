using System;
namespace Game
{
	class MainClass
	{
//		public static void Main (string[] args)
//		{
//			int a = Console.WriteLine();
//			int b = Console.WriteLine();
//			int [][] array = new int[a][b]; 
//					Console.WriteLine ("test");
//					Console.WriteLine ("test");
//				}
//			}
//		}

		public static void Main (string[] args) {
			int tableSizeX = int.Parse(Console.ReadLine()); //5
			int tableSizeY = int.Parse(Console.ReadLine()); //7

			Random r = new Random();
			int P1LocationX = r.Next (0, tableSizeX);
			int P1LocationY = r.Next (0, tableSizeY);
		}
	}
}
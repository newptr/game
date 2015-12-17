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

		static int tableSizeX ;
		static int tableSizeY ;
		static Random r = new Random();
		
		public static void Main (string[] args) {

			int[] P1Location = RandomLocation ();
			PrintLocation( 1, P1Location );

			int[] P2Location = RandomLocation ();
			PrintLocation( 2, P2Location );
		}
		public static int[] RandomLocation() {
			return new int[2]{ r.Next (0, tableSizeX - 1), r.Next (0, tableSizeY - 1) };
		}

		public static void PrintLocation( int playerId, int[] location ) {
			Console.WriteLine("player in this world > id: " + playerId + " " + location[0] + " " + location[1]);
		} 
		Console.WriteLine("Move")
		public static int[] Up(){
			return new int[2]{r.Next(0,tableSizeX-1),r.Next (0, tableSizeY)}; 
		}
		public static int[] Down(){
			return new int[2]{r.Next(0,tableSizeX-1),r.Next (0, tableSizeY-2)}; 
		}
		public static int[] Left(){
			return new int[2]{r.Next(0,tableSizeX),r.Next (0, tableSizeY-1)}; 
		}
		public static int[] Down(){
			return new int[2]{r.Next(0,tableSizeX-2),r.Next (0, tableSizeY-1)}; 
		}
		}
	}
}
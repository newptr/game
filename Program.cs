using System;
namespace Game
{
	class MainClass
	{
		static int tableSizeX ;
		static int tableSizeY ;
		static Random r = new Random();
		
		public static void Main (string[] args) {

			tableSizeX = int.Parse (Console.ReadLine ());
			tableSizeY = int.Parse (Console.ReadLine ());

			int[] P1Location = RandomLocation ();
			PrintLocation (1, P1Location);

			int[] P2Location = RandomLocation ();
			PrintLocation (2, P2Location);

			while (true) {
				ConsoleKeyInfo keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.UpArrow) {
					MoveLocation ("up", P1Location);
				} else if (keyInfo.Key == ConsoleKey.DownArrow) {
					MoveLocation ("down", P1Location);
				} else if (keyInfo.Key == ConsoleKey.LeftArrow) {
					MoveLocation ("left", P1Location);
				} else if (keyInfo.Key == ConsoleKey.RightArrow) {
					MoveLocation ("right", P1Location);
				}
				PrintMovedLocation (1, P1Location);
			}
		}

		public static int[] RandomLocation() {
			return new int[2]{ r.Next (0, tableSizeX - 1), r.Next (0, tableSizeY - 1) };
		}

		public static void PrintLocation( int playerId, int[] location ) {
			Console.WriteLine("player in this world > id: " + playerId + " " + location[0] + " " + location[1]);
		}

		public static void PrintMovedLocation( int playerId, int[] location ) {
			Console.WriteLine("player " + playerId + " moved to " + location[0] + " " + location[1]);
		}

		public static void MoveLocation( string command, int[] location){
			switch(command){
			case "up":
				if (location [1] < tableSizeY) {
					location [1] += 1;
				}
				break;
				case "down":
				if (location [1] > 0) {
					location [1] -= 1;
				}
				break;
				case "left":
				if (location [0] > 0) {
					location [0] -= 1;
				}
				break;
				case "right":
				if (location [0] < tableSizeX) {
					location [0] += 1;
				}
				break;
			}
//			public static void PrintMoveLocation(){
//				Console.WriteLine();
//				public 
//			
//			if (keyInfo.Key == ConsoleKey.UpArrow) {
//
//			} else if (keyInfo.Key == ConsoleKey.DownArrow) {
//
////			} ...
		}
	}
}
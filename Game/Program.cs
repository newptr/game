using System;
namespace Game
{
	class MainClass
	{
		static int tableSizeX ;
		static int tableSizeY ;
		static Random r = new Random();
		
		public static void Main (string[] args) {
			tableSizeX = int.Parse(Console.ReadLine ());
			tableSizeY = int.Parse(Console.ReadLine ());

			int[] P1Location = RandomLocation ();
			PrintLocation( 1, P1Location );

			int[] P2Location = RandomLocation ();
			PrintLocation( 2, P2Location );

			while (true) {
				String control = Console.ReadLine ();

				Console.WriteLine ("Move" + control);
				MoveLocation (control, P1Location);
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
			Console.WriteLine("player " + playerId + " moved to" + location[0] + " " + location[1]);
		}

		public static void MoveLocation( string command, int[] location){
			switch(command){
			case "Up":
				location [1] += 1;
				break;
				case "Down":
				location [1] -= 1;
				break;
				case "Left":
				location [0] -= 1;
				break;
				case "Right":
				location [0] += 1;
				break;
				default:
				Console.WriteLine ("Exit program");
				break;
			}
		}
	}
}
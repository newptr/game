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
			}
			public static int[] RandomLocation() {
				return new int[2]{ r.Next (0, tableSizeX - 1), r.Next (0, tableSizeY - 1) };
			}
			public static void PrintLocation( int playerId, int[] location ) {
				Console.WriteLine("player in this world > id: " + playerId + " " + location[0] + " " + location[1]);
			} 
			/*public static int Control(){
				String Control = Console.ReadLine(); 
				Console.WriteLine("Move"+Control);
				switch(Control){
					case "Up":

					break;
					case ("Down"):
					
					break;
					case ("Left"):
					
					break;
					case ("Right"):
					 
					break;
			default:
				Console.WriteLine ("Exit program");
				break;
				}
			}*/
	}
}
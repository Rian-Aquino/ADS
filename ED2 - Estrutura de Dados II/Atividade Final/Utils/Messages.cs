
using System;

namespace Projeto_Locação.Utils
{
	static public class Messages
	{
		public static void W(string msg) {
			Console.Write("  " + msg);
		}
		
		public static void Wl(string msg) {
			Console.WriteLine("  " + msg);
		}
		
		public static void ErrorMessage(string msg) {
			Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n  X " + msg);
            Console.ResetColor();
		}
		
		public static void SuccessMessage(string msg) {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n  V " + msg);
            Console.ResetColor();
		}
		
		public static void Continue() {
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write("  Pressione qualquer tecla para continuar . . .");
			Console.ResetColor();
			Console.ReadKey();
		}
	}
}

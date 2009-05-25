/*
 * Creato da SharpDevelop.
 * Utente: Mattias Cibien
 * Data: 22/05/2009
 * Ora: 15.21
 *
 */
using System;

namespace Doomed
{
	class MainProgram
	{
		public static void Main(string[] args)
		{
			DoomMain main = new DoomMain();
			
			main.RunMainLoop(args);
			
			Console.ReadKey(true);
		}
	}
}
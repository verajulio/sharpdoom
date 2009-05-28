using System;

namespace Doomed
{
	class MainProgram
	{
		public static void Main(string[] args)
		{
			DoomMain main = new DoomMain();
			
			main.RunMainLoop(args);
		}
	}
}
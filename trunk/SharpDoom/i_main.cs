using System;

namespace SharpDoom
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
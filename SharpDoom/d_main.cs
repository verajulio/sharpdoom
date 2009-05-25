/*
 * Creato da SharpDevelop.
 * Utente: Mattias Cibien
 * Data: 22/05/2009
 * Ora: 15.23
 *
 */
using System;
using System.Collections;
using System.IO;

namespace Doomed
{
	/// <summary>
	/// Main Game Class featuring the way to play the game
	/// </summary>
	public class DoomMain
	{
		int Vestion 
		{
			get
			{
				return 100;
			}
		}
		GameMode GameMode
		{
			get; set;
		}
		
		bool DevMode
		{
			get; set;
		}
		
		ArrayList files = new ArrayList();
		
		void AddFile(FileInfo file)
		{
			files.Add(file);
		}
		
		/// <summary>
		/// Not a globally visible function, just included for source reference,
		/// calls all startup code, parses command line options.
		/// If not overrided by user input, calls N_AdvanceDemo.
		/// </summary>
		public void RunMainLoop(string[] args)
		{
			ArgStore.Args = args;
			Console.Title = "SharpDoom 1.0";
			IdentifyVersion();
			Console.WriteLine("Hello! I am the main Doom Loop... I do quite nothing now\nexcept for checking the game version and active WAD Files\n\n");
			object[] array = files.ToArray();
#if DEBUG
			foreach(object o in array)
			{
				Console.WriteLine(((FileInfo)o).FullName);
			}
#endif
		}
		
		/// <summary>
		/// Used to identify which game is played.
		/// </summary>		
		private void IdentifyVersion()
		{
		    FileInfo	doom1wad;
    		FileInfo	doomwad;
    		FileInfo	doomuwad;
    		FileInfo	doom2wad;

    		FileInfo	plutoniawad;
    		FileInfo	tntwad;
    		
    		string doomwaddir = System.Environment.GetEnvironmentVariable("DOOMWADDIR");
    		if(doomwaddir == null)
    			doomwaddir = System.Environment.CurrentDirectory;
    		
    		// Doom 2.
    		doom2wad = new FileInfo(String.Concat(doomwaddir, "\\doom2.wad"));

   			 // Retail (I don't know what is this).
   			 doomuwad = new FileInfo(String.Concat(doomwaddir, "\\doomu.wad"));
    
    		// Registered.
    		doomwad = new FileInfo(String.Concat(doomwaddir, "\\doom.wad"));
    
    		// Shareware.
    		doom1wad = new FileInfo(String.Concat(doomwaddir, "\\doom1.wad"));
    		
    		// Plutonia
    		plutoniawad = new FileInfo(String.Concat(doomwaddir, "\\plutonia.wad"));
    		
    		// TNT.
    		tntwad = new FileInfo(String.Concat(doomwaddir, "\\tnt.wad"));
    		
    		// -- Doom French Removed
    		
/*  		Actually I cannot handle this sice some files may be missing!
    		if(ArgStore.CheckParam("-shdev"))
    		{
    		   GameMode = GameMode.Shareware;
    		   DevMode = true;

    		   return;
    		}
    		   
    		if(ArgStore.CheckParam("-regdev"))
    		{
    		   GameMode = GameMode.Registered;
    		   DevMode = true;

    		   return;
    		}
    		
    		if(ArgStore.CheckParam("-comdev"))
    		{   
    			GameMode = GameMode.Commercial;
    			DevMode = true;

    		}
*/   		
    		if(doom2wad.Exists)
    		{
    			GameMode = GameMode.Commercial;
    			AddFile(doom2wad);
    			return;
    		}
    		
    		if(plutoniawad.Exists)
    		{
    			GameMode = GameMode.Commercial;
				AddFile(plutoniawad);
    			return;
    		}
    		if(tntwad.Exists)
    		{
    			GameMode = GameMode.Commercial;
				AddFile(tntwad);
    			return;
    		}
    		if(doomuwad.Exists)
    		{
    			GameMode = GameMode.Registered;
    			AddFile(doomuwad);
    			return;
    		}
    		
    		if(doomwad.Exists)
    		{
    			GameMode = GameMode.Registered;
    			AddFile(doomwad);
    			return;
    		}
    		
    		if(doom1wad.Exists)
    		{
    			GameMode = GameMode.Shareware;
    			AddFile(doom1wad);
    			return;
    		}
    		    		
    		Console.WriteLine("Game Mode Indeterminate");
    		GameMode = GameMode.Indetermined;
    		
		}
		
		/// <summary>
		/// Called by IO functions when input is detected.
		/// </summary>
		void PostEvent(Event ev)
		{
		
		}


		//
		// BASE LEVEL
		//
		
		/*
		void D_PageTicker();
		void D_PageDrawer();
		void D_AdvanceDemo();
		void D_StartTitle();
		*/
	}
}

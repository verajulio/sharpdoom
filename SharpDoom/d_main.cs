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
        #region Properties
        int Version 
		{
			get
			{
                return 100;
			}
		}

        string Title
        {
            get;
            set;
        }

        ArrayList Events
        {
            get;
            set;
        }

		GameMode GameMode
		{
			get; set;
		}

        GameMission GameMission
        {
            get;
            set;
        }
		
		bool DevMode
		{
			get; set;
        }
        #endregion
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
            Console.WriteLine("Engine Initialized");
			IdentifyVersion();

            switch ( GameMode )
            {
                case GameMode.Retail:
                    Title = String.Format("The Ultimate DOOM Startup v{0}.{1}", Version/100,Version%100);
	                break;
                case GameMode.Shareware:
                    Title = String.Format("DOOM Shareware Startup v{0}.{1}", Version/100,Version%100);
	                break;
                case GameMode.Registered:
	                Title = String.Format("DOOM Registered Startup v{0}.{1}", Version/100,Version%100);
	                break;
                case GameMode.Commercial:
                    Title = String.Format("DOOM 2: Hell on Earth v{0}.{1}",Version/100,Version%100);
	                break;
                default:
                    Title = String.Format("Public DOOM - v{0}.{1}", Version/100,Version%100);
	            break;
            }
            switch (GameMission)
            {
                case GameMission.PackPlut:
                    Title = String.Format("DOOM 2: Plutonia Experiment v{0}.{1}", Version / 100, Version % 100);
                    break;
                case GameMission.PackTnt:
                    Title = String.Format("DOOM 2: TNT - Evilution v{0}.{1}", Version / 100, Version % 100);
                    break;
                default:
                    //Leave as before ;)
                    break;
            }

            Console.Title = String.Concat(Title);
            Console.WriteLine(String.Concat("\n", Title, "\n"));

            Console.ReadKey(true);
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
                GameMission = GameMission.Doom2;
    			AddFile(doom2wad);
    			return;
    		}   		
    		if(plutoniawad.Exists)
    		{
    			GameMode = GameMode.Commercial;
                GameMission = GameMission.PackPlut;
				AddFile(plutoniawad);
    			return;
    		}
    		if(tntwad.Exists)
    		{
    			GameMode = GameMode.Commercial;
                GameMission = GameMission.PackTnt;
				AddFile(tntwad);
    			return;
    		}
    		if(doomuwad.Exists)
    		{
    			GameMode = GameMode.Retail;
                GameMission = GameMission.Doom;
    			AddFile(doomuwad);
    			return;
    		}
    		if(doomwad.Exists)
    		{
    			GameMode = GameMode.Registered;
                GameMission = GameMission.Doom;
    			AddFile(doomwad);
    			return;
    		}
    		if(doom1wad.Exists)
    		{
    			GameMode = GameMode.Shareware;
                GameMission = GameMission.Doom;
    			AddFile(doom1wad);
    			return;
    		}
    		    		
    		Console.WriteLine("Game Mode Indeterminated");
    		GameMode = GameMode.Indetermined;
            GameMission = GameMission.None;
    		
		}
		
		/// <summary>
		/// Called by IO functions when input is detected.
		/// </summary>
		void PostEvent(Event ev)
		{
            Events.Add(ev);
		}

        void ProcessEvents()
        {
            foreach (Event ev in Events)
            {
                //ev = &events[eventtail];
                //if (M_Responder(ev))
                //   continue;               // menu ate the event
                //G_Responder(ev);
            }
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

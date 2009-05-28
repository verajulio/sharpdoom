/*
 * Creato da SharpDevelop.
 * Utente: Mattias Cibien
 * Data: 22/05/2009
 * Ora: 21.49
 * 
 */


namespace SharpDoom
{
    /// <summary>
    /// Player states.
    /// </summary>
    enum PlayerState
    {
    // Playing or camping.
    LIVE,
    // Dead on the ground, view follows killer.
    DEAD,
    // Ready to restart/respawn???
    REBORN		

    };

/// <summary>
/// Player internal flags, for cheats and debug.
/// </summary>
    enum Cheat
    {
        // No clipping, walk through barriers.
        NOCLIP		= 1,
        // No damage, no health loss.
        GODMODE		= 2,
        // Not really a cheat, just a debug aid.
        NOMOMENTUM	= 4
    };

    /// <summary>
    /// Extended player object info: player_t
    /// </summary>
    public class Player
    {
        public static int MAXPLAYERS
        {
            get
            {
                return 4;
            }
        }
        MapObject	MapObject;
        PlayerState	PlayerState;
        //ticcmd_t		cmd;

        // Determine POV,
        //  including viewpoint bobbing during movement.
        // Focal origin above r.z
        float		ViewZ;
        // Base height above floor for viewz.
        float		ViewHeight;
        // Bob/squat speed.
        float         	DeltaViewHeight;
        // bounded/scaled total momentum.
        float         	Bob;	

        // This is only used between levels,
        // mo->health is used during levels.
        int			Health;	
        int			ArmorPoints;
        // Armor type is 0-2.
        int			ArmorType;
        
        // Power ups. invinc and invis are tic counters.
        int[]       Powers = new int[(int)(PowerType.NUMPOWERS)];

        bool[]      Cards = new bool[(int)(Card.NUMCARDS)];
        bool		Backpack;
     
        // Frags, kills of other players.

        int[] Frags = new int[Player.MAXPLAYERS];
        WeaponType	ReadyWeapon;
        
        // Is wp_nochange if not changing.
        WeaponType	PendingWeapon;

        bool[]		WeaponOwned = new bool[(int)(WeaponType.NUMWEAPONS)];
        int[]		Ammo = new int[(int)(AmmoType.NUMAMMO)];
        int[]       MaxAmmo = new int[(int)(AmmoType.NUMAMMO)];
        // True if button down last tic.
        int			AttackDown;
        int			UseDown;

        // Bit flags, for cheats and debug.
        // See cheat_t, above.
        int			Cheats;		

        // Refired shots are less accurate.
        int			Refire;		

         // For intermission stats.
        int			KillCount;
        int			ItemCount;
        int			SecretCount;

        // Hint messages.
        string		Message;	
        
        // For screen flashing (red or bright).
        int			DamageCount;
        int			BonusCount;

        // Who did damage (NULL for floors/ceilings).
        MapObject		Attacker;
        
        // So gun flashes light up areas.
        int			ExtraLight;

        // Current PLAYPAL, ???
        //  can be set to REDCOLORMAP for pain, etc.
        int			FixedColorMap;

        // Player skin colorshift,
        //  0-3 for which color to draw player.
        int			ColorMap;	

        // Overlay view sprites (gun, etc).
        //pspdef_t		psprites[NUMPSPRITES];

        // True if secret level has been done.
        bool		DidSecret;	

    }


    //
    // INTERMISSION
    // Structure passed e.g. to WI_Start(wb)
    //
    struct WbPlayerStruct
    {
        bool	IsInGame;	// whether the player is in game
        
        // Player stats, kills, collected items etc.
        int		Skills;
        int		Sitems;
        int		Ssecret;
        int		Stime;
        int[]   Frags;
        int		Score;	// current score on entry, modified on return
      
    };

    public class WbStartStruct
    {
        int		Espisode;	// episode # (0-2)

        // if true, splash the secret level
        bool	DidSecret;
        
        // previous and next levels, origin 0
        int		Last;
        int		Next;	
        
        int		MaxKills;
        int		MaxItems;
        int		MaxSecret;
        int		MaxFrags;

        // the par time
        int		ParTime;
        
        // index of this player in game
        int		PlayerNumber;

        WbPlayerStruct[] Players = new WbPlayerStruct[Player.MAXPLAYERS];

    };
}

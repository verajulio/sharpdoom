//TODO: should be finished

/// <summary>
/// Game mode handling - identify IWAD version
/// to handle IWAD dependend animations etc
/// </summary>

namespace SharpDoom
{
    enum GameMode
    {
        Shareware,	// DOOM 1 shareware, E1, M9
        Registered,	// DOOM 1 registered, E3, M27
        Commercial,	// DOOM 2 retail, E1 M34
        // DOOM 2 german edition not handled
        Retail,	// DOOM 1 retail, E4, M36
        Indetermined	// Well, no IWAD found.

    };

    /// <summary>
    /// Mission packs - might be useful for TC stuff?
    /// </summary>
    enum GameMission
    {
        Doom,		// DOOM 1
        Doom2,	// DOOM 2
        PackTnt,	// TNT mission pack
        PackPlut,	// Plutonia pack
        None

    };
    /// <summary>
    /// Identify language to use, software localization.
    /// </summary>
    enum Language
    {
        English,
        French,
        German,
        Unknown

    };

    /// <summary>
    /// The current state of the game: whether we are
    /// playing, gazing at the intermission screen,
    /// the game final animation, or a demo. 
    /// </summary>
    enum GameState
    {
        LEVEL,
        INTERMISSION,
        FINALE,
        DEMOSCREEN
    };

    enum Skill
    {
        Baby,
        Easy,
        Medium,
        Hard,
        Nightmare
    };

    /// <summary>
    /// Key cards.
    /// </summary>
    enum Card
    {
        BlueCard,
        YellowCard,
        RedCard,
        BlueSkull,
        YellowSkull,
        RedSkull,

        NUMCARDS

    };
    /// <summary>
    /// The defined weapons,
    /// including a marker indicating
    /// user has not changed weapon.
    /// </summary>
    enum WeaponType
    {
        Fist,
        Pistol,
        Shotgun,
        Chaingun,
        Missile,
        Plasma,
        Bfg,
        Chainsaw,
        Supershotgun,

        NUMWEAPONS,

        // No pending weapon change.
        NoChange
    };

    /// <summary>
    /// Ammunition types defined.
    /// </summary>
    enum AmmoType
    {
        Clip,	// Pistol / chaingun ammo.
        Shell,	// Shotgun / double barreled shotgun.
        Cell,	// Plasma rifle, BFG.
        Misl,	// Missile launcher.
        NUMAMMO,
        NoAmmo	// Unlimited for chainsaw / fist.	
    };

    /// <summary>
    /// Power up artifacts.
    /// </summary>
    enum PowerType
    {
        Invulnerability,
        Strength,
        Invisibility,
        Ironfeet,
        Allmap,
        Infrared,

        NUMPOWERS

    };
}
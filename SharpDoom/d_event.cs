/*
 * Creato da SharpDevelop.
 * Utente: Mattias Cibien
 * Data: 22/05/2009
 * Ora: 20.48
 * 
 */

/// <summary>
/// Input event types.
/// </summary>
enum EventType
{
    KeyDown,
    KeyUp,
    Mouse,
    Joystick
};

/// <summary>
/// Event structure.
/// </summary>
struct Event
{
    EventType	Type;
    int		Data1;		// keys / mouse/joystick buttons
    int		Data2;		// mouse/joystick x move
    int		Data3;		// mouse/joystick y move
};

enum  GameAction
{
    Nothing,
    LoadLevel,
    NewGame,
    LoadGame,
    SaveGame,
    PlayDemo,
    Completed,
    Victory,
    WorldDone,
    Screenshot
};

/// <summary>
/// Button/action code definitions.
/// </summary>
enum ButtonCode
{
	// Press "Fire".
	BT_ATTACK		= 1,
	// Use button, to open doors, activate switches.
    BT_USE		= 2,

    // Flag: game events, not really buttons.
    BT_SPECIAL		= 128,
    BT_SPECIALMASK	= 3,
    
    // Flag, weapon change pending.
    // If true, the next 3 bits hold weapon num.
    BT_CHANGE		= 4,
    // The 3bit weapon mask and shift, convenience.
    BT_WEAPONMASK	= (8+16+32),
    BT_WEAPONSHIFT	= 3,

    // Pause the game.
    BTS_PAUSE		= 1,
    // Save the game at each console.
    BTS_SAVEGAME	= 2,

    // Savegame slot numbers
    //  occupy the second byte of buttons.    
    BTS_SAVEMASK	= (4+8+16),
    BTS_SAVESHIFT 	= 2,
  
};

//event_t[]	events;
//int	eventhead;
//int eventtail;

//gameaction_t gameaction;
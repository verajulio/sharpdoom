using System;

namespace SharpDoom
{
    struct TicCmd
    {
        char forwardmove;	// *2048 for move
        char sidemove;	// *2048 for move
        short angleturn;	// <<16 for angle delta
        short consistancy;	// checks for net game
        byte chatchar;
        byte buttons;
    }
}

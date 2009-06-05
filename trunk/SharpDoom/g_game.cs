using System;

namespace SharpDoom
{
    public class Game
    {
        void DeathMatchSpawnPlayer(int playernum)
        {

        }

        void InitNew(Skill skill, int episode, int map)
        {

        }

        // Can be called by the startup code or M_Responder.
        // A normal game starts at map 1,
        // but a warp test can start elsewhere
        void DeferedInitNew(Skill skill, int episode, int map)
        {

        }

        void DeferedPlayDemo(string demo)
        {

        }

        // Can be called by the startup code or M_Responder,
        // calls P_SetupLevel or W_EnterWorld.
        void LoadGame(string name)
        {

        }

        void DoLoadGame()
        {

        }

        // Called by M_Responder.
        void SaveGame(int slot, string description)
        {

        }

        // Only called by startup code.
        void RecordDemo(string name)
        {

        }

        void BeginRecording()
        {

        }

        void PlayDemo(string name)
        {

        }
        void TimeDemo(string name)
        {

        }
        bool CheckDemoStatus()
        {
            return true;
        }

        void ExitLevel()
        {

        }
        void SecretExitLevel()
        {

        }

        void WorldDone()
        {

        }


        void Ticker()
        {

        }

        bool Responder(Event ev)
        {
            return true;
        }

        void ScreenShot()
        {

        }
    }
}

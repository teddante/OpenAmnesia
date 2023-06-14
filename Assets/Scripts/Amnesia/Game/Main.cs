using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals
{
    /// <summary>
    /// Entry point for the game. Initializes and runs the game, and handles any errors that occur.
    /// </summary>
    /// <param name="asCommandline">The command line arguments passed to the game.</param>
    /// <returns>0 if the game ran successfully, otherwise an error code.</returns>
    // Converted from original, ready for work
    public int HplMain(string asCommandline)
    {
        cLuxBase gpBase = new cLuxBase();

        if (gpBase.Init(asCommandline))
        {
            gpBase.Run();
            gpBase.Exit();
        }
        else
        {
            if (gpBase.msErrorMessage == "")
                gpBase.msErrorMessage = "Error occured";

            cPlatform.CreateMessageBox("Error!", gpBase.msErrorMessage);
        }

        gpBase = null;

        return 0;
    }
}
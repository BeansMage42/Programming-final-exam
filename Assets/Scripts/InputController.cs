using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputController
{
    private static Inputs controls;

    public static void Init(BallController myPlayer)
    {
        controls = new Inputs();

        controls.GameMode.Switch.started += ctx =>
        {
            Debug.Log("Called");
            myPlayer.SetMoveDir();
        };

    }

    public static void GameEnable()
    {
        controls.GameMode.Enable();
    }
    public static void GameDisable()
    {
        controls.GameMode.Disable();
    }
}

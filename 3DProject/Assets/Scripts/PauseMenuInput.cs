using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuInput : MonoBehaviour
{
    [SerializeField]
    private Canvas pauseMenu;
    private bool pauseIsUp;
    private Canvas spawnedPauseMenu;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (spawnedPauseMenu == null)
            {
                spawnedPauseMenu = HudManager.AddUIToScreen(pauseMenu);
            }
            else
            {
                HudManager.RemoveUIFromScreen(spawnedPauseMenu);
            }

        }





    }
}


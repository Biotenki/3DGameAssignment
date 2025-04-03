using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class HudManager : MonoBehaviour
{
    [SerializeField]
    private Canvas mainMenu;
   


    private void Start()
    {
        AddUIToScreen(mainMenu); //Start menu
    }

    public static Canvas AddUIToScreen(Canvas uiPrefab)
    {
        if (uiPrefab != null)
        {
          return Instantiate(uiPrefab);
        }
        else
        {
            Debug.LogWarning("No valid UI prefab to spawn");
        }

        return null;

    }

   
    
    public static void RemoveUIFromScreen(Canvas ui)
    {
        if (ui != null)
        {
            Destroy(ui.gameObject);
        }
        else 
        {

            Debug.LogWarning("Trying to destroy invalid UI");
        }
        
    }


    private void Update()
    {
       
    
    
    }



}

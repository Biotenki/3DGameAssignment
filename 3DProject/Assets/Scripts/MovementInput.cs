using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController), typeof(PlayerInput))]

public class MovementInput : MonoBehaviour
{

    private CharacterController controller => this.GetComponent<CharacterController>() ;
    private Vector3 combined;

    [SerializeField]
    private int speed = 5;

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>();
        Vector3 forwards = this.transform.forward * input.y;
        Vector3 right = this.transform.right * input.x;

        combined = Vector3.Normalize(forwards + right);
        

    }

  public void OnLooking(InputAction.CallbackContext context) 
    {
    
    }


 private void Update()
    {
        controller.SimpleMove(combined * speed);
    }


}

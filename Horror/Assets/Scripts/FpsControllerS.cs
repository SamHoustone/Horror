using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsControllerS : MonoBehaviour
{
  public CharacterController characterController;
 #region PlayerMovementVars
    public float speed = 12f;
  public float gravity = -9.19f;
  public float jumpHeight;

  public Transform groundCheck;
  public float groundDistance;
  public LayerMask groundMask;

  Vector3 velocity;
  bool isGrounded;
    float z =1f;

#endregion
  
  private void Start() {
      Cursor.lockState = CursorLockMode.Locked;
  }
  private void Update() 
  {
      #region PlayerMovement

       isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance,groundMask);

      if(isGrounded && velocity.y < 0)
      {
          velocity.y = -2f;
      }

     // float x = Input.GetAxis("Horizontal");
       if(Input.GetKey(KeyCode.W)) {
            Vector3 move = transform.forward * z;
            characterController.Move(move * speed * Time.deltaTime);
        }

     

     

     //if(Input.GetButtonDown("Jump") && isGrounded)
    // {
      //   velocity.y = Mathf.Sqrt(jumpHeight);
    // }  
     
     velocity.y += gravity * Time.deltaTime;
     characterController.Move(velocity * Time.deltaTime);
      #endregion
      
  }
}

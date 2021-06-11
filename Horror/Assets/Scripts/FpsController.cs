using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    public CharacterController characterController;
 #region PlayerMovementVars
    public float speed = 12f;
  public float gravity = -9.19f;
  Vector3 velocity;
  bool isGrounded;

#endregion
  
  private void Start() {
      Cursor.lockState = CursorLockMode.Locked;
  }
  private void Update() 
  {
       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;

       characterController.Move(move * speed * Time.deltaTime);

      characterController.Move(velocity * Time.deltaTime);
  }
}

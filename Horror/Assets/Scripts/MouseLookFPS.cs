using UnityEngine;
 using System.Collections;

 public class MouseLookFPS : MonoBehaviour {
     public float horizontalSpeed = 2.0F;
     public float verticalSpeed = 2.0F;
     void Update() 
     {
         float h = horizontalSpeed * Input.GetAxis("Mouse X");
         float v = verticalSpeed * Input.GetAxis("Mouse Y");
         
         v = Mathf.Clamp(v,- 90f,90f);
         transform.Rotate(v, h, 0);
     }
 }
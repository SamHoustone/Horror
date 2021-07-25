using System;
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookFPS : MonoBehaviour
{
public float mouseSensitivity;
public Transform playerBody;
float xRotation;
float yRotation;

    private void Start()
{
    Cursor.lockState = CursorLockMode.Locked;
}
    void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

       yRotation += mouseX;
       xRotation += mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);
        xRotation = Mathf.Clamp(xRotation, -90f,90f);

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
       playerBody.Rotate(Vector3.up * mouseX);
    }
}

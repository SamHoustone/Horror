using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPad : MonoBehaviour
{
    public GameObject Keypad;
    public DoorController maindoorController;
    public string GivenAnswer;
    public TMP_InputField AnswerText;
    public bool isOpen;
    private void Update()
    {
        AnswerText.text = GivenAnswer;
        
        if(GivenAnswer == "1947")
        {
            Keypad.SetActive(false);
            maindoorController.DoorAnimator.Play("DoorClose");
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void GetInput(string givenInput)
    {
      GivenAnswer += givenInput;
    }
    public void CalculatorAnimation()
    {
      if(isOpen)
      {
        Debug.Log("LOCKED");
        Cursor.lockState = CursorLockMode.Locked;
        isOpen = false;
        Keypad.SetActive(false);
      }
      else
      {
          Debug.Log("UNLOCKED");
          isOpen = true;
          Cursor.lockState = CursorLockMode.None;
          Keypad.SetActive(true);
      }
    }
    public void Reset()
    {
        GivenAnswer = "";
    }
}

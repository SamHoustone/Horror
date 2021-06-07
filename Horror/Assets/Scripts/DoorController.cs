using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isOpen;
    public Animator DoorAnimator;

    public void Door()
    {
        Debug.Log("sf");
        if(isOpen)
        {
            DoorAnimator.Play("DoorClose");
            isOpen = false;
        }
        else
        {
            DoorAnimator.Play("DoorOpen");
            isOpen = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
  public Camera PlayerCamera;
  public int range;
  public GameObject Torch;
  public GameObject Fuse;
  public TextMeshProUGUI DialougeText;
  public Image img1;
  public Image img2;
  public KeyPad keyPad;
  
    bool PickedFuse;
   public bool key1,key2,key3;
    public GameObject Fuse1;
    public GameObject Fuse2;
    public GameObject Fuse3;
    public GameObject FFLights;
    public GameObject GFLights;
    public AudioSource rdo;

    public Animator animator;
    private void Start()
    {
     Cursor.lockState = CursorLockMode.Locked;
        keyPad = FindObjectOfType<KeyPad>();
        DialougeText.text ="";
    }

    void Update()
    {
        Key();
        Door();
        RaycastHit hit;
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, range))
        {
            if (hit.transform.name == "Torch")
            {
                img1.enabled = true;
            }
            else
            {

                img1.enabled = false;
            }

            if (hit.transform.name == "Fuse")
            {

                img2.enabled = true;
            }
            else
            {

                img2.enabled = false;
            } 
        }
         if(Input.GetMouseButtonDown(0) && keyPad.isOpen == false)
        {
             if(hit.transform.name == "MainDoor")
            {
               keyPad.CalculatorAnimation();    
               Cursor.lockState = CursorLockMode.None;
            }
        }

        
    }
    public void Key()
    {
        if(Input.GetMouseButtonDown(0))
       {
        RaycastHit hit;
        if(Physics.Raycast(PlayerCamera.transform.position,PlayerCamera.transform.forward,out hit, range))
        {
            if(hit.transform.name == "Key1")
            {
                key1 = true;
                hit.transform.gameObject.SetActive(false);
            }
            if(hit.transform.name == "Key2")
            {
                key2 = true;
                hit.transform.gameObject.SetActive(false);
            }
            if(hit.transform.name == "Key3")
            {
                key3 = true;
                hit.transform.gameObject.SetActive(false);
            }
        }
       }
    }
  public void Door()
  {
    if(Input.GetMouseButtonDown(0))
    {
    RaycastHit hit;
    if(Physics.Raycast(PlayerCamera.transform.position,PlayerCamera.transform.forward,out hit, range))
    {
        //KEYS AND DOOR
        if(hit.transform.name == "Door")
        {
            hit.transform.GetComponent<DoorController>().Door();
        }
        if(hit.transform.name == "Door1" && key1 == true)
        {
          hit.transform.GetComponent<DoorController>().Door();
        }
        else if(hit.transform.name == "Door1" && key1 == false)
        {
            DialougeText.text = "YOU DONT HAVE THE KEY";
            StartCoroutine(DisabelDialouge());
        }
        if(hit.transform.name == "Door2" && key2 == true)
        {
          hit.transform.GetComponent<DoorController>().Door();
        }
        else if(hit.transform.name == "Door2" && key2 == false)
        {
            DialougeText.text = "YOU DONT HAVE THE KEY";
            StartCoroutine(DisabelDialouge());
        }
        if(hit.transform.name == "Door3" && key3 == true)
        {
          hit.transform.GetComponent<DoorController>().Door();
        }
        else if(hit.transform.name == "Door3" && key3 == false)
        {
            DialougeText.text = "YOU DONT HAVE THE KEY";
            StartCoroutine(DisabelDialouge());
        }
        //TORCH
      if(hit.transform.name == "Torch")
      {
          hit.transform.gameObject.SetActive(false);
          Torch.SetActive(true);
      }
       if(hit.transform.name == "Fuse")
      {
          hit.transform.gameObject.SetActive(false);
          Fuse.SetActive(true);
          PickedFuse = true;
      }
      //FUSE
      else if(hit.transform.name == "Fuse1")
                {
                    hit.transform.gameObject.SetActive(false);
                    Fuse.SetActive(true);
                    PickedFuse = true;
                    FFLights.SetActive(false);
                }else if(hit.transform.name == "Fuse2")
                {
                    hit.transform.gameObject.SetActive(false);
                    Fuse.SetActive(true);
                    PickedFuse = true;
                    GFLights.SetActive(false);
                }
                else if (hit.transform.name == "Fuse3")
                {
                    hit.transform.gameObject.SetActive(false);
                    Fuse.SetActive(true);
                    PickedFuse = true;
                }


      if (hit.transform.name == "FuseH1" && PickedFuse == true)
      {
         // hit.transform.GetComponent<Animator>().Play("FusePuzzle");
                   Fuse.SetActive(false);
                    Fuse1.SetActive(true);
                    FFLights.SetActive(true);
                    PickedFuse = false;
                    rdo.Play();
                    animator.Play("DoorCloseJumpScare");
      }
      else if(hit.transform.name == "FuseH2" && PickedFuse == true)
      {
                    Fuse.SetActive(false);
                    Fuse2.SetActive(true);
                    GFLights.SetActive(true);
                    rdo.Play();
                    PickedFuse = false;
                    animator.Play("DoorCloseJumpScare");

      }
                else if (hit.transform.name == "FuseH2" && PickedFuse == true)
                {
                    Fuse.SetActive(false);
                    Fuse3.SetActive(true);
                    PickedFuse = false;
                    animator.Play("DoorCloseJumpScare");

                }
            }
    }
  }
  IEnumerator DisabelDialouge()
  {
      yield return new  WaitForSeconds(8f);
      DialougeText.text = "";

  }
}

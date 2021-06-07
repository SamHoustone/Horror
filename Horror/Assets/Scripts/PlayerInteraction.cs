using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
  public Camera PlayerCamera;
  public int range;
  public GameObject Torch;
  public GameObject Fuse;
  public Image img1;
  public Image img2;
   bool PickedFuse;
    public GameObject Fuse1;
    public GameObject Fuse2;
    public GameObject Fuse3;
    public GameObject FFLights;
    public GameObject GFLights;

    void Update()
    {
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

        
    }
  public void Door()
  {
    if(Input.GetMouseButtonDown(0))
    {
    RaycastHit hit;
    if(Physics.Raycast(PlayerCamera.transform.position,PlayerCamera.transform.forward,out hit, range))
    {
        if(hit.transform.tag == "Door")
        {
          hit.transform.GetComponent<DoorController>().Door();
        }
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
      }else if(hit.transform.name == "Fuse1")
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
      }
      else if(hit.transform.name == "FuseH2" && PickedFuse == true)
      {
                    Fuse.SetActive(false);
                    Fuse2.SetActive(true);
                    GFLights.SetActive(true);
                    PickedFuse = false;
      }
                else if (hit.transform.name == "FuseH2" && PickedFuse == true)
                {
                    Fuse.SetActive(false);
                    Fuse3.SetActive(true);
                    PickedFuse = false;
                }
            }
    }
  }
}

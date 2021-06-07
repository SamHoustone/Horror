using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
  public Camera PlayerCamera;
  public int range;
  public GameObject Torch;
  public GameObject Fuse;
  bool PickedFuse;
    void Update()
    {
        Door();
    }
  void Door()
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
      }
      if(hit.transform.name == "FuseBox" && PickedFuse == true)
      {
          hit.transform.GetComponent<Animator>().Play("FusePuzzle");
      }
    }
    }
  }
}

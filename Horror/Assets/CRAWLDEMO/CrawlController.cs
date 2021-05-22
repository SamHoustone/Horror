using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlController : MonoBehaviour
{
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
          animator.enabled = true;  
          animator.Play("Crawl");
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
          animator.enabled = false;
        }
    }
}

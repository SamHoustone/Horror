using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject timeline;
    public CrawlController crawlController;
    public Animator anim;
    public FpsController fps;
    
    private void OnTriggerEnter(Collider other) {
        
        if(other.CompareTag("Player"))
        {
            timeline.SetActive(true);
            crawlController.enabled = false;
            anim.enabled = false;
            fps.enabled = false;
        }
    }
}

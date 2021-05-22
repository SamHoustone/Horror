using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject timeline;
    public CrawlController crawlController;
    
    private void OnTriggerEnter(Collider other) {
        
        if(other.CompareTag("Player"))
        {
            timeline.SetActive(true);
            crawlController.enabled = false;
        }
    }
}

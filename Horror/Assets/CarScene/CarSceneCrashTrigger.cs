using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSceneCrashTrigger : MonoBehaviour
{
    public GameObject rock1,rock2,rock3,rock4;
    public CameraShake cameraShake;
    public GameObject Timeline;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            cameraShake.enabled = true;
            rock1.SetActive(true);
            rock2.SetActive(true);
            rock3.SetActive(true);
            rock4.SetActive(true);
            Timeline.SetActive(true);

        }
    }
}

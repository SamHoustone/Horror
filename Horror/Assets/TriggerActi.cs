using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActi : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obj1.SetActive(true);
            obj2.SetActive(false);
            Destroy(obj2);
            Destroy(gameObject);
        }
    }
}

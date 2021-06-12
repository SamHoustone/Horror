using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Characters.FirstPerson
{
    public class TimelineTrigger : MonoBehaviour
    {
        public GameObject timeline;
        public FirstPersonController fps;


        private void Start()
        {
            timeline.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                timeline.SetActive(true);
                Destroy(gameObject);
                
                fps.m_WalkSpeed = 1f;
                fps.m_RunSpeed = 1f;
            }
        }
    }
}

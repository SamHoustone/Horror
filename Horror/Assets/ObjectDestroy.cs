using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Characters.FirstPerson
{

   
    public class ObjectDestroy : MonoBehaviour
    {

        public FirstPersonController fps;
        public GameObject pp;
        public GameObject timeline;
        //public Animator


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                fps.m_WalkSpeed = 3;
                fps.m_RunSpeed = 3;
                Destroy(pp);
                Destroy(gameObject);
                Destroy(timeline);
            }
        }
    }
}

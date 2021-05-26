using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinComponent : MonoBehaviour
{
    public GameManager gameManager;
    public Transform transformCube;
    private void Start() 
    {
        gameManager = FindObjectOfType<GameManager>();
        StartCoroutine(DestroyCoins());
    }
    void Update()
    {
        transformCube.Rotate(new Vector3(10,10,10) * Time.deltaTime);
    }
  IEnumerator DestroyCoins ()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) 
    {
     if(other.CompareTag("Player"))
     {
         Destroy(gameObject);
         gameManager.CollectedCoins++;
     }   
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
      public Text Score;
      public float time;
      public int CollectedCoins;
       
       private void Update() 
       {
           if(time > 0)
           {
               time -= Time.deltaTime;
           }
           Score.text = time.ToString();
       }

        IEnumerator AddNewCoin()
        {
            yield return new WaitForSeconds(13);
            Instantiate(coin, transform);
        }

}

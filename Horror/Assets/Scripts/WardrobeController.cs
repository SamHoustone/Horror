using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class WardrobeController : MonoBehaviour
{
    bool isUsed;
    public PlayableDirector playableDirector;

   public void Wardrobe()
    {
        if(!isUsed)
        {
         playableDirector.Play();
        }
    }
}

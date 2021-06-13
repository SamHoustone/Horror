using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public int sceneL = 1;

    void Start()
    {
        SceneManager.LoadScene(sceneL);
    }

    

}

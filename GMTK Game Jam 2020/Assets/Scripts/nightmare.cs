using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nightmare : MonoBehaviour
{
    private int timer = 0;
   

    void Update()
    {
        if (timer < 100)
        {
            timer++;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("game has been loaded");
        }
       

    }
    
}

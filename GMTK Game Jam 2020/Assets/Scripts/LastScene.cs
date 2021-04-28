using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour
{
    private int i = 0;
    void Update()
    {
        if (i < 1150)
        {
            i++;
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

}

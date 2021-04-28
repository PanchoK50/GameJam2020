using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitGame : MonoBehaviour
{

    private Button exitButton;

    public void QuitGame()
    {
       
        Application.Quit();
        Debug.Log("Game is exiting");
       
    }
  

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCounter : MonoBehaviour
{

    public int itemAmmount = 0;
    public GameObject currentWordtext;
    public bool wordFinished;
    public string word1 = "Remember!";
    public string word2 = "Remember! You";
    public string word3 = "Remember! You can";
    public string word4 = "Remember! You can do";
    public string word5 = "Remember! You can do it!";

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (itemAmmount == 0)
        {
            currentWordtext.GetComponent<Text>().enabled = false;
        }

        if (itemAmmount > 0)
        {
            currentWordtext.GetComponent<Text>().enabled = true;
        }

        if (itemAmmount == 1)
        {
            currentWordtext.GetComponent<Text>().text = word1;
        }

        if (itemAmmount == 2)
        {
            currentWordtext.GetComponent<Text>().text = word2;
        }

        if (itemAmmount == 3)
        {
            currentWordtext.GetComponent<Text>().text = word3;
        }
        
        if (itemAmmount == 4)
        {
            currentWordtext.GetComponent<Text>().text = word4;
        }
        
        if (itemAmmount >= 5)
        {
            currentWordtext.GetComponent<Text>().text = word5;
            wordFinished = true;
        }
    }
}

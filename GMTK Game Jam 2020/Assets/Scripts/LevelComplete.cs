using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    
    public GameObject completeLevelMessage;
    public Sprite portalOpen;
    public Sprite portalClosed;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && GameObject.Find("ItemCounter").GetComponent<ItemCounter>().wordFinished) 
        {
            Debug.Log("Trigger triggered!");
            completeLevelMessage.SetActive(true);
        }

        

    }

    void Update()
    {
        if (GameObject.Find("ItemCounter").GetComponent<ItemCounter>().wordFinished == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = portalOpen;
            Debug.Log("Portal open!");
           
        }
    }

}

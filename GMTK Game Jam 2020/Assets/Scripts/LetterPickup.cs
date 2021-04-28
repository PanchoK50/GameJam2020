using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterPickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            GameObject.Find("ItemCounter").GetComponent<ItemCounter>().itemAmmount += 1;
            Destroy(gameObject);
        }
    }
}

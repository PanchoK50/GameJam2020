using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void GasDeath()
    {
        GameObject.Find("Player").GetComponent<playerMovement>().GasRespawn();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    
}

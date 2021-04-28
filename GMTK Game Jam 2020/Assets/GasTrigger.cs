using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasTrigger : MonoBehaviour
{
    public GameObject shortGas;
    public GameObject longGas;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameObject.Find("AmbientControler").GetComponent<cameraBackground>().colorIndex == 3)
        {
            longGas.SetActive(true);
        }
        else shortGas.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        shortGas.SetActive(false);
        longGas.SetActive(false);
    }

}

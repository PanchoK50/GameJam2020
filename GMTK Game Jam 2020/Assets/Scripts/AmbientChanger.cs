using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbientChanger : MonoBehaviour
{

    bool ActiveTimer = false;
    float timeLeft;
    public float timeMax = 10f;
    public float timeMin = 15f;
    public GameObject timer;
    public GameObject ambientController;
    int randomambient = 0;
    int pastambient = 0;

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 5)
        {
            timer.GetComponent<Text>().enabled = false;
        }
        
        if(ActiveTimer == false)
        {
            timeLeft = Random.Range(timeMin, timeMax);
            ActiveTimer = true;
            ambientController.GetComponent<cameraBackground>().colorIndex = randomambient;
            
            while(randomambient == pastambient)
            {
                randomambient = Random.Range(0, 4);
            }
            pastambient = randomambient;
        }

        if (ActiveTimer)
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft <= 0)
            {
                ActiveTimer = false;
                ambientController.GetComponent<cameraBackground>().colorIndex = 0;
            }

            if(timeLeft <= 5)
            {
                timer.GetComponent<Text>().enabled = true;
                timer.GetComponent<Text>().text = timeLeft.ToString("0");
            }

            

        }


        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace myNameSpace
{
    
    public class animationFramerate : MonoBehaviour
    {
        public int target = 24;
        private int i = 1;

        // Start is called before the first frame update
        void Start()
        {
            QualitySettings.vSyncCount = 0;
            // Application.targetFrameRate = 24;
        }

        // Update is called once per frame
        void Update()
        {
            if (target != Application.targetFrameRate)
            {
                Application.targetFrameRate = target;

            }

            if(i < 201)
                {
                i++;
                }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("MainMenu has been loaded");
            }
        }
    }
}
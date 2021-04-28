using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestryAudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBackground : MonoBehaviour
{
    public Camera targetCamera;
    public int colorIndex = 0;
    // 0 white, 1 red, 2 blue, 3 green
    public Color BackgroundColor;
    public Color white;
    public Color blue;
    public Color red;
    public Color green;
    public Color black;
    public Color purple;
    public Color yellow;
    MeshRenderer myRenderer;

    
    // Update is called once per frame
    void Update()
    {
        if(colorIndex == 0)
        {
            BackgroundColor = white;
        }
        if(colorIndex == 1)
        {
            BackgroundColor = red;
        }
        if(colorIndex == 2)
        {
            BackgroundColor = blue;
        }
        if (colorIndex == 3)
        {
            BackgroundColor = green;
        }
        targetCamera.backgroundColor = BackgroundColor;
    }
}

using UnityEngine;

public class IceTrigger : MonoBehaviour
{
    public bool iceTrigger = false;

    void OnTriggerEnter2D()
    {
        iceTrigger = true;
    }

    void OnTriggerExit2D()
    {
        iceTrigger = false;
    }

    void Update()
    {
        
    }
}

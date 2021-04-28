using UnityEngine;

public class AmbientCheck : MonoBehaviour
{

    public GameObject ambient;
    public GameObject lava_tilemap;
    public GameObject gas_tilemap;
    public GameObject water_tilemap;
    public GameObject ice_tilemap;
    int currentAmbient;
    
    void Update()
    {
        currentAmbient = ambient.GetComponent<cameraBackground>().colorIndex;
        //normal water
        if (currentAmbient == 0)
        {
            water_tilemap.GetComponent<Collider2D>().enabled = false;
        }
        else if (currentAmbient != 0)
        {
            water_tilemap.GetComponent<Collider2D>().enabled = true;
        }

        // lava collider de/activation
        if (currentAmbient == 1)
        {
            lava_tilemap.GetComponent<Collider2D>().enabled = false;
        }
        else if (currentAmbient != 1){
            lava_tilemap.GetComponent<Collider2D>().enabled = true;
        }

        //blue ice slippery
        if (currentAmbient != 2)
        {
            ice_tilemap.GetComponent<Collider2D>().enabled = true;
        }
        else if (currentAmbient == 2)
        {
            ice_tilemap.GetComponent<Collider2D>().enabled = false;
        }


        //green
        if (currentAmbient == 3)
        {

        }

    }



}

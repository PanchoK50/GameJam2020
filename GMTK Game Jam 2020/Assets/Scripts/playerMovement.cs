using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float iceMoveSpeed = 7.5f;
    public Rigidbody2D rb;
    Vector3 spawnposition;
    Vector2 movement;
    Vector2 slipperyMovement;
    public GameObject iceTilemap;
    public GameObject currentAmbient;
    

    private void Start()
    {
        spawnposition = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.SqrMagnitude() != 0)
        {
            slipperyMovement = movement;
        }

        if (Input.GetKeyDown("b"))
        {
            rb.position = spawnposition;
        }

    }

    private void FixedUpdate()
    {
        if(iceTilemap.GetComponent<IceTrigger>().iceTrigger == true)
        {
            rb.MovePosition(rb.position + slipperyMovement * iceMoveSpeed * Time.fixedDeltaTime);
        }

        else rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void GasRespawn()
    {
        rb.position = spawnposition;
    }

}

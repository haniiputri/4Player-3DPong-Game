using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRLControl : MonoBehaviour
{
    private float speed = 10;

    public Rigidbody rb;

    public KeyCode upKey;
    public KeyCode downKey;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(upKey))
        {
           rb.velocity = new Vector3(0f, 0f, speed); 
        }
        else if(Input.GetKey(downKey))
        {
            rb.velocity = new Vector3(0f, 0f, -speed);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
        }
    }
}

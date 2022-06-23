using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTBControl : MonoBehaviour
{
    private float speed = 10;

    public Rigidbody rb;

    public KeyCode leftKey;
    public KeyCode rightKey;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(leftKey))
        {
            rb.velocity = new Vector3(-speed, 0f, 0f);
        }
        else if (Input.GetKey(rightKey))
        {
            rb.velocity = new Vector3(speed, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
        }
    }
}

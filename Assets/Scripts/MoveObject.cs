using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour

{
    private Rigidbody rb;
    public float speed = 0.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);

        rb.AddForce(movement * speed);

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : Enemy
{
    public Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //
    }


    protected override void Move()
    {
        base.Move();

        rigidBody2D.rotation += 10.0f;
    }

    private void Rotate()
    {
        //transform.Rotate(rotationVector);
        //transform.rotation = Quaternion.Euler(Vector3.forward * 90);
        //transform.eulerAngles = new Vector3(0, 0, 50);
        //transform.eulerAngles = Vector3.forward * 50;
    }
}

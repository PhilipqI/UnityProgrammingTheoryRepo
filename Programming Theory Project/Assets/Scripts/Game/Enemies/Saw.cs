using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Saw : Enemy
{
    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }


    // POLYMORPHISM
    protected override void Move()
    {
        base.Move();
        rigidBody2D.rotation += 10.0f;
    }
}

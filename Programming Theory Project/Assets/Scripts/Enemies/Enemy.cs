using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float upperPosY = 5;
    [SerializeField] private float lowerPosY = 0;

    public bool dirDown = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();   
    }

    protected virtual void Move()
    {
        //use Space.World to support movement even, when rotation is applied 
        if (dirDown)
            transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);
        else
            transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);

        if (transform.position.y <= lowerPosY)
        {
            dirDown = false;
        }
        
        if(transform.position.y >= upperPosY)
        {
            dirDown = true;
        }
    }
}

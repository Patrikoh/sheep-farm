﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveRandomly : MonoBehaviour
{
    private float timeToChangeDirection;
    private bool isMoving = true;
    private Vector3 movingDirection;
    public float speed;

    // Use this for initialization
    public void Start()
    {
        InvokeRepeating("ChangeDirection", 0f, Random.Range(2f,5f));
    
    }

    // Update is called once per frame
    public void Update()
    {     
        if (isMoving)
        {
            transform.Translate(Vector3.forward * speed);
        }
    }

    public void ChangeDirection()
    {

        if (Random.value > 0.5f)
        {
            isMoving = !isMoving;
        }
        if (isMoving)
        {
            transform.Rotate(Vector3.up, Random.Range(1f, 360f));
        }

    }

}
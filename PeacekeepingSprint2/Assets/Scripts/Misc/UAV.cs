﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UAV : MonoBehaviour
{

    ////////CURRENTLY NO PLANS FOR UAV IN GAME////////

    //variables
    public float Speed = 0;
    public float sensitivity = 10f;

    void Update()
    {
        
        //controls and speed
        float xAxisValue = Input.GetAxis("Horizontal") * Speed;
        float zAxisValue = Input.GetAxis("Vertical") * Speed;
        float yValue = 0.0f;

        if (Input.GetKey(KeyCode.Q))
        {
            yValue = -Speed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            yValue = Speed;
        }

        //movement
        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yValue, transform.position.z + zAxisValue);
        
    }
}


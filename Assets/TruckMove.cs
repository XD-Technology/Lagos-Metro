﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{
    [SerializeField] private float speed;


    private void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.fixedDeltaTime);
    }
}

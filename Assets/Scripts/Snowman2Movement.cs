﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman2Movement : MonoBehaviour {

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        GetComponent<Rigidbody2D>().MovePosition(pos);
    }
}
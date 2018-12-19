﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Level2 : MonoBehaviour
{

    public GameObject[] Waypoints;
    int current = 0;
    public float speed;
    float WPradius = 0.1f;


    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(Waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;

            if (current >= Waypoints.Length)
            {
                current = 0;
                Destroy(this.gameObject);
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, Waypoints[current].transform.position, Time.deltaTime * speed);
    }
}

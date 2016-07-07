﻿using UnityEngine;
using System.Collections;

public class DucklingAI : MonoBehaviour
{

    // Runs to mother / to designed Transform around mom duck
    // Should have some delay and maybe trip ? 

    float speed = 2f;
    public Transform landingDestination;
    public bool moving = false;

    void Start()
    {

    }

    void Update()
    {
        if (moving)
        {
            Waddle();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        // play FX, remove duckling from landing zone (@mom), remove GO and update GM
        // only car tire can hit ducklings 

        if (col.gameObject.tag == "CarAIWheel")
        {

        }
    }

    void Waddle()
    {
        transform.position = Vector3.MoveTowards(transform.position, landingDestination.position, speed * Time.deltaTime);
        //transform.LookAt(currWaypoint);
        Vector3 temp = transform.position;
        temp.y = 0.196f;
        transform.position = temp;
    }
}
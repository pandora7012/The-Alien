using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling408 : MonoBehaviour
{
    public float speed = 1f;
    public Transform[] waypoints;

    int currentWaypointIndex = 0;
    
    public void Patrolling()
    {
        transform.position = waypoints[0].position;
        if (transform.position != waypoints[0].transform.position)
        {
            Vector2.MoveTowards(this.transform.position, waypoints[1].transform.position, speed * Time.deltaTime);
        }
        else if (transform.position != waypoints[1].transform.position)
        {
            Vector2.MoveTowards(this.transform.position, waypoints[0].transform.position, speed * Time.deltaTime);
        }
    }
}
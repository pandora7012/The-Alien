using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling408 : MonoBehaviour
{
    public float speed = 1f;
    public Transform[] waypoints;

    public void Patrolling()
    {
        if (transform.position != waypoints[0].transform.position)
        {
            Vector2.MoveTowards(this.transform.position, waypoints[0].transform.position, speed * Time.deltaTime);
        }
        else
        {
            Vector2.MoveTowards(this.transform.position, waypoints[0].transform.position, speed * Time.deltaTime);
        }
    }
}
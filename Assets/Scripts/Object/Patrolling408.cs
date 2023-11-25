using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Patrolling408 : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] public List<Transform> waypoints;

    int currentWaypointIndex = 0; //


    public void Patrolling()
    {
        var child = transform.GetChild(0);
        float step = speed * Time.deltaTime;
        child.localPosition = Vector2.MoveTowards(child.localPosition, waypoints[currentWaypointIndex].localPosition,
            step);
        
        if (Vector3.Distance(child.localPosition, waypoints[currentWaypointIndex].localPosition) < 0.001f)
        {
            currentWaypointIndex = currentWaypointIndex == 0 ? 1 : 0;
            if (gameObject.CompareTag("GroundMonster"))
                transform.GetChild(0). GetComponent<SpriteRenderer>().flipX =  currentWaypointIndex ==  0 ? false : true;
        }
    }
}
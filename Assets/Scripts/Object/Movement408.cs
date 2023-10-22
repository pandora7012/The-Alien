using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDF408 : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;

    private int _currentWaypointIndex = 0;
    private float _speed = 5f;

    private void Update()
    {
        if (_currentWaypointIndex < _waypoints.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position, _waypoints[_currentWaypointIndex].position,
                _speed * Time.deltaTime);

            if (transform.position == _waypoints[_currentWaypointIndex].position)
            {
                _currentWaypointIndex++;
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < _waypoints.Length; i++)
        {
            Gizmos.DrawSphere(_waypoints[i].position, 0.2f);
        }
    }
    
    
}
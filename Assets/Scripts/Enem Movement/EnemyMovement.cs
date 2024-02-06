using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float distanceFromTraget;
    private Transform _target;
    private int _currentIndex = 0;
    private void Start()
    {
        _target = WayPoints.WayPointsList[_currentIndex];
    }

    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed*Time.deltaTime);
        if (Vector3.Distance(transform.position, _target.position) > distanceFromTraget || _currentIndex+1 == WayPoints.WayPointsList.Count)
            return;
        _currentIndex++;
        _target = WayPoints.WayPointsList[_currentIndex].transform;
    }
}

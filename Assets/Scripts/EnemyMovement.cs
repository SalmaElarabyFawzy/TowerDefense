using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private float distanceFromTraget;
    private Transform _target;
    private int _currentIndex = 0;
    private void Start()
    {
        _target = GameMaster.WayPoints[_currentIndex];
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed*Time.deltaTime);
        if (Vector3.Distance(transform.position, _target.position) > distanceFromTraget || _currentIndex+1 == GameMaster.WayPoints.Count)
            return;
        _currentIndex++;
        _target = GameMaster.WayPoints[_currentIndex].transform;
    }
}

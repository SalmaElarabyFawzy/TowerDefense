using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 5;
    private Transform _target;
    
    // Update is called once per frame
    private void Update()
    {
        if (_target is null)
        {
            // Destroy takes time before it happens
            Destroy(gameObject);
            return;
        }
        var direction = _target.position - transform.position;
        //Space.World
        transform.Translate(direction.normalized * bulletSpeed * Time.deltaTime , Space.World);
    }
    internal void SetTarget(Transform target) => _target = target;
}

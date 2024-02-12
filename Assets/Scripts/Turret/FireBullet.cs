using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate;
    [SerializeField] private FindEnemy findEnemy;
    private float _timeToFire;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(_timeToFire<=0)
        {
            Fire();
            _timeToFire = 1/fireRate;
        }
        _timeToFire -= Time.deltaTime;
    }
    private void Fire()
    {
        if(findEnemy.Target is null)
            return;
        var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.TryGetComponent(out BulletMove bulletInfo);
        if (bulletInfo is null)
            return;
        bulletInfo.SetTarget(findEnemy.Target);
    }
    
}

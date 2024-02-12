using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    [SerializeField] private FindEnemy findEnemy;
    [SerializeField] private Transform rotationPoint;
    [SerializeField] private float rotationSpeed;
    
    
    // Update is called once per frame
    private void Update()
    {
        LookAtEnemy();
    }

    private void LookAtEnemy()
    {
        if(findEnemy.Target is null || findEnemy.Target.IsDestroyed())
            return;
        var direction = findEnemy.Target.position - transform.position;
        // Search for LookRotation
        var lookRotation = Quaternion.LookRotation(direction);
        
        // Search for difference between rotation and Rotate
        // Quaternion
        var rotation = Quaternion.Lerp(rotationPoint.rotation,lookRotation , rotationSpeed*Time.deltaTime).eulerAngles;
        rotationPoint.rotation = Quaternion.Euler(rotationPoint.rotation.eulerAngles.x, rotation.y, rotationPoint.rotation.eulerAngles.z);
    }
}

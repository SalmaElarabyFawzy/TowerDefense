using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
   [SerializeField] private BulletEffect bulletEffect;
   private void OnTriggerEnter(Collider other)
   {
       if(!other.gameObject.CompareTag("Enemy"))
           return; 
       bulletEffect.Effect();
       Destroy(other.gameObject);
       Destroy(gameObject);
   }
   
}

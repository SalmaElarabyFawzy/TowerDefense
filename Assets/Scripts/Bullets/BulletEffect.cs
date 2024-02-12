using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour
{
    [SerializeField] private GameObject bulletEffect;


    internal void Effect()
    {
        var effect = Instantiate(bulletEffect, transform.position, transform.rotation);
        Destroy(effect , 2f);
    }
    
}

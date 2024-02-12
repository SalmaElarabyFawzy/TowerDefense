using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float timeBetweenSpawns;
    internal static float CountDown { get; private set; }
    private int _enemyNumber =0;
    private bool _spawned = true;

    private void Start()
    {
        CountDown = 2f;
    }

    private void Update()
    {
        if (CountDown <= 0)
        {
            StartCoroutine(Spawn());
            CountDown = timeBetweenSpawns;
            _spawned = false;
        }

        if (_spawned)
            CountDown -= Time.deltaTime;
    }
    private IEnumerator Spawn()
    {
        _enemyNumber++;
        for (var i = 1; i <= _enemyNumber; i++)
        {
            Instantiate(enemyPrefab, transform.position, enemyPrefab.transform.rotation);
            yield return new WaitForSeconds(1f);
        }
        _spawned = true;
    }
    
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownUI : MonoBehaviour
{
    [SerializeField] private TMP_Text countDownText;
    
    private void Update()
    {
        countDownText.text = Mathf.Round(WaveSpawner.CountDown).ToString();
    }
}

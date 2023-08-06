using System;
using System.Collections;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;



public class Timer : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private TextMeshProUGUI timerText;

    private float _timeLeft = 0f;
  

    private IEnumerator StartTimer()
    {
        Random rnd = new Random();
        int timeRnd = rnd.Next(45, 75);
        int Reverse = -1;
        while (_timeLeft > 0)
        {
            if (_timeLeft <= timeRnd) Reverse *= -1;
            if (_timeLeft >= 121) Reverse *= -1;
            _timeLeft += Time.deltaTime * Reverse;
            UpdateTimeText();
            yield return null;
        }
    }

    private void Start()
    {
        _timeLeft = time;
        StartCoroutine(StartTimer());        
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;
        
        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}

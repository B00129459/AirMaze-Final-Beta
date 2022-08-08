using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{
    float currentTime;
    public float startingTime = 90f;

    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 5f;
    private bool countingDown = true;
    BallMove balls;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (countingDown) 
        {

            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                countingDown = false;
                countdownText.gameObject.SetActive(false);
                balls = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMove>();
                balls.resetPosition();
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text text;
    float timeLeft;
    bool running = false;
	// Use this for initialization
	void Start () {
        text = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (running)
        {
            Countdown();
        }
	}

    void Countdown()
    {
        timeLeft -= Time.deltaTime;
        text.text = Math.Ceiling(timeLeft).ToString();
        if (timeLeft < 0)
        {
            running = false;
        }
    }

    public void SetTimer(float time)
    {
        timeLeft = time;
    }

    public void StartTimer()
    {
        running = true;
    }

    public bool IsRunning()
    {
        return running;
    }

    public float GetTime()
    {
        return timeLeft;
    }
}

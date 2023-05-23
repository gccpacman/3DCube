using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot;

    [SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;

    float hoursToDegrees = -30;
    float minutesToDegrees = -6;
    float secondsToDegrees = -6;

    void Awake()
    {
        //DateTime time = DateTime.Now;
        //Debug.Log(time);
        //hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
        //minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
        //secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);
        //Debug.Log(hoursPivot.localRotation + " " + minutesPivot.localRotation + " " + secondsPivot.localRotation);
    }

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;
        Debug.Log(time);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);
        Debug.Log(hoursPivot.localRotation + " " + minutesPivot.localRotation + " " + secondsPivot.localRotation);
    }
}

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

    private void Awake()
    {
        Debug.Log(DateTime.Now);
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * DateTime.Now.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * DateTime.Now.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * DateTime.Now.Second);
        Debug.Log(hoursPivot.localRotation + " " + minutesPivot.localRotation + " " + secondsPivot.localRotation);
    }

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timespan : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime futureDate;
    [SerializeField] private TimeSpan duration;
    [SerializeField] private double totalMinutes;

    void Start()
    {
        TimeSpan duration = new TimeSpan(1, 30, 0); // 1 hour, 30 minutes
        Debug.Log("TimeSpan Duration: " + duration);

        now = DateTime.Now;
        futureDate = now.AddDays(10);
        Debug.Log("Future Date: " + futureDate);
        duration = new TimeSpan(2, 15, 0);
        totalMinutes = duration.TotalMinutes;
        Debug.Log("Total Minutes: " + totalMinutes);
    }
}
    
   

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    [SerializeField] private DateTime now;
    [SerializeField] private DateTime specificDate;
    // Start is called before the first frame update
    void Start()
    {
        now = DateTime.Now;
        specificDate = new DateTime(2024, 10, 23);

        Debug.Log("Current Date and time:" + now);
        Debug.Log("Specific Date:" + specificDate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

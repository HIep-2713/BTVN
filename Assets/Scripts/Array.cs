using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] private int[] numbers = new int [10];
    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = 1;
        numbers[1] = 2; 
        numbers[2] = 3;
        numbers[3] = 4; 
        numbers[4] = 5;
        numbers[5] = 6;
        numbers[6] = 7;
        numbers[7] = 8;
        numbers[8] = 9;
        numbers[9] = 10;

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log("Elment" + i + ":" + numbers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] private string greeting;
    [SerializeField] private new string name;
    [SerializeField] private string Welcome;
    // Start is called before the first frame update
    void Start()
    {
        message = "Hello HIep";
        greeting = "Hello ," + "HIep";
        name = "Handsomeboy";
        Welcome = $"Welcome {name} Hiep";

        Debug.Log(message);
        Debug.Log(greeting);
        Debug.Log(name);
        Debug.Log(Welcome);
        Debug.Log(name.Length);
        Debug.Log(name.ToUpper());
        Debug.Log(name.ToLower());
        Debug.Log(name.Substring(3,3));
        Debug.Log(name.Replace("H", "D"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

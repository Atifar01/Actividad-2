using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string phrase;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World, " + phrase);

    }
    
    void Update()
    {
        print("Hello World, " + phrase);
    }
}
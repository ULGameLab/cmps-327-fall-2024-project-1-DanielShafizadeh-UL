using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Awake triggered");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start triggered");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update triggered");
    }
}

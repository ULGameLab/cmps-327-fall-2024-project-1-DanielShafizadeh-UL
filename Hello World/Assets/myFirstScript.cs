using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    //Called to load in necessary resources during script loading for object, in this case, just logging the execution
    void Awake()
    {
        Debug.Log("Awake triggered");
    }
    // Start is called before the first frame update to initialize everything needed for the object, in this case, only logging the execution
    void Start()
    {
        Debug.Log("Start triggered");
        
    }

    // Update is called once per frame, logging the execution only when MonoBehavior is on
    void Update()
    {
        Debug.Log("Update triggered");
    }
}

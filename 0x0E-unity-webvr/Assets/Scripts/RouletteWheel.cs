using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class RouletteWheel : MonoBehaviour
{
    public GameObject wheel;
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        wheel.transform.Rotate(0, 45 * Time.deltaTime, 0);
    }
}
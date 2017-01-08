using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanish : MonoBehaviour {

    int count = 0;

    private void Start()
    {
        
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }
        if (count >= 3)
        {
            vanish();
            count = 0;
        }
        
    }

    void vanish()
    {
        Destroy(gameObject);
    }
}

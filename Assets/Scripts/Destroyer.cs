﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        //destroys object after a certain amount of time to clear hierachy
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

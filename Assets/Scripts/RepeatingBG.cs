﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    private void Update(){
        //moves left
        transform.Translate(Vector2.left*speed*Time.deltaTime);

        //snaps background to right of the sceen once it leaves to the left
        if (transform.position.x <= endX){
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position=pos;
        }
    }

}

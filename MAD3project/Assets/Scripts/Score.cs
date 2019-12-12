using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //This class is made reduntant as I implemented everything here into the player class
    //I kept this here to show the early structure of the project
    public int score;
    public Text scoreDisplay;

    void Update(){
        //scoreDisplay.text = score.ToString();
    }
    
    void onTriggerEnter2D(Collider2D other){
        Debug.Log("test");
        score++;
        Debug.Log(score);
    }
}

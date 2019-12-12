using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawner : MonoBehaviour {

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime;

    public GameObject[] obstaclePatterns;
    public Text speedDisplay;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            //picks random number from 1 to (size of array)
            int rand = Random.Range(0, obstaclePatterns.Length);
            //spawns particular obstacle pattern
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            //IndexOutOfRangeException: Index was outside the bounds of the array.
            timeBtwSpawns = startTimeBtwSpawns;
            
            //string.Format("{0:0.0#}",timeBtwSpawns);
            //display speed in relation to time between spawns.
            //As time between spawns goes down, speed is increased
            speedDisplay.text = "x"+string.Format("{0:0.0#}",(timeBtwSpawns*-1)+4).ToString();

            //this doesn't allow time between spawns to go below min value
            //otherwise, game would eventually be impossible
            if(startTimeBtwSpawns>minTime){
                startTimeBtwSpawns -= timeDecrease;
            }
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
        

    }
    

}
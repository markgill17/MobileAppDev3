using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSpawner : MonoBehaviour
{
    
    //this is a simplified version of spawner for the tutorial
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime;

    public GameObject[] obstaclePatterns;
    // Start is called before the first frame update
    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
     private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            //IndexOutOfRangeException: Index was outside the bounds of the array.
            timeBtwSpawns = startTimeBtwSpawns;
            if(startTimeBtwSpawns>minTime){
                startTimeBtwSpawns -= timeDecrease;
            }
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
        

    }
}

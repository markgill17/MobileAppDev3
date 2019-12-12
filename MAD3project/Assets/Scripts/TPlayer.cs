using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPlayer : MonoBehaviour
{

    //this is a simplified version of player for the tutorial
    public float speed;
    public float increment;
    public float maxY;
    public float minY;
    private Vector2 targetPos;

    public Animator camAnim;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        //Player.score=0;
        //Player.isDead=false;
        //PauseMenu.GameIsPaused=false;
        //Player.score++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }
}

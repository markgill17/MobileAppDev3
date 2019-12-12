using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public float speed;
    public float increment;
    public float maxY;
    public float minY;
    public float health;
    public bool isDead;

    public int score;
    public int endScore;

    public Text scoreDisplay;
    private Vector2 targetPos;
    private Shake shake;
    public Animator camAnim;
    public Text healthDisplay;
    public Text endScoreDisplay;
    //public Text speedDisplay;
    public GameObject gameOverMenuUI;
    public GameObject pauseMenuUI;
    public static bool GameIsOver = false;
    public static bool GameIsPaused = false;

    void Start(){
        Time.timeScale = 1f;
        score=0;
        isDead=false;
        GameIsPaused=false;
    }

    //i left logs in code to show what i was testing
    void Update()
    {
        /*if(PauseMenu.GameIsPaused){
            Debug.Log("Game is paused ");
        }*/
        //register Esc press
        if(Input.GetKeyDown(KeyCode.Escape)){

            //Debug.Log("Entered loop");
            if(GameIsPaused){
                //if game is paused and Esc is pressed, game resumes
                Resume();
            }
        
            else{
                //Debug.Log("Entered loop 2");
                //if game isn't paused when Esc is pressed, pause game
                Pause();
            }
            //Debug.Log("Left loop 2");

        }
        else if(GameIsOver){
            //Debug.Log("Game is over ");
        }
        else{
            //Debug.Log("Game running");
            //score++;
        }

        if(GameIsPaused){
            //This is my most effective way to stop the score
        }else{
            score++;
        }
        
        //needed to output values on canvas
        healthDisplay.text = health.ToString();
        scoreDisplay.text = score.ToString();

        //when player dies, game is over
        if(health<=0){
            GameIsOver = true;
            //Destroy(gameObject);
            //removes game object upon ast impact
            gameObject.SetActive(false);
            if(GameIsOver){
                endScore=score;
                endScoreDisplay.text = "Final Score: " + endScore.ToString();
                GameOver();
            }
        }

        //first attempt trying to output speed
        //speedDisplay.text = "x"+string.Format("{0:0.0#}",speed*4).ToString();

        //moves player right to center of screen
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //doesn't allow character out of bounds
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY) {
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        } 
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY) {
            //camAnim.SetTrigger("shake");
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }

    //when the game is over, player is dead and speed of background is halved.
    public void GameOver (){
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0.5f;
        isDead = true;
    }

    //quit game takes you to Menu scene
    public void QuitGame(){
        SceneManager.LoadScene("Menu");
    }

    //resume removes pause canvas and resets speed
    public void Resume (){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //pause brings up pause canvas and removes all speed
    void Pause (){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
 
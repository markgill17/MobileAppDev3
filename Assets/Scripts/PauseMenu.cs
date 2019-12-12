using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //This class is made reduntant as I implemented everything here into the player class
    //I kept this here to show the early structure of the project
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Start(){
        GameIsPaused=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
        
            else{
                Pause();
            }
        }
    }

    public void Resume (){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause (){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame(){
        SceneManager.LoadScene("Menu");
    }
}

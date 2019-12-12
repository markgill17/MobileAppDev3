using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if Esc is pressed, start game
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Game");
        }
        
    }
}

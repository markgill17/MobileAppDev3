using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    //This class is made reduntant as I implemented everything here into the player class
    //I kept this here to show the early structure of the project
    public Animator camAnim;

    public void CamShake(){
        camAnim.SetTrigger("shake");
    }

}

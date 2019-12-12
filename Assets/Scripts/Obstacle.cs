using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour {

    public int score;
    public Text scoreDisplay;
    public Text speedDisplay;
    public float speed;
    public float startSpeed;
    public float speedIncrease;
    public GameObject effect;
    public GameObject explosionSound;
    private Animator camAnim;
    public AudioSource crashEffect;
    private Shake shake;

    public void Start(){
        speed = startSpeed;
        crashEffect=GetComponent<AudioSource>();
        //shake=GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

	public void Update () {
        startSpeed++;
        speed += speedIncrease;
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //---EARLY ATTEMPTS AT SPEED DISPLAY--------
        //speedDisplay.text = "x"+string.Format("{0:0.0#}",speed).ToString().GetComponent<Text>();
        //speedDisplay = "x"+string.Format("{0:0.0#}",speed).ToString().GameObject.FindWithTag("Obstacle").GetComponent<Text>(); 
        //float speedFloatVal=(float)speed;
        //Debug.Log(speed);
        //speedDisplay.text = speed.ToString();
        //Debug.Log(speed);
        //speedDisplay.text = speed.ToString();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //detects asterois/player collision
        if (other.gameObject.name == "Player") {
            //makes crash sound
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            //decrements health
            other.GetComponent<Player>().health--;
            Debug.Log(other.GetComponent<Player>().health);
            crashEffect.Play();
            //FindObjectOfType<AudioManager>().Play("Crash");
            //shake.CamShake();
            //makes camera shake nimation
            other.GetComponent<Player>().camAnim.SetTrigger("shake");
            //makes particle effect
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //gameObject.SetActive(false);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }// OnCollisionEnter2D
}
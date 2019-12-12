using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    //This class is made reduntant as I implemented everything here into the player class
    //I kept this here to show the early structure of the project

    public string name;
    public AudioClip clip;
    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3)]
    public float pitch;
    public bool loop;
    public bool playOnAwake;
    [HideInInspector]
    public AudioSource audioSource;

}
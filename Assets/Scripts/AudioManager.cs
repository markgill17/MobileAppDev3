using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need to import system to use array
using System;

public class AudioManager : MonoBehaviour
{

    //This class is made reduntant as I implemented everything here into the player class
    //I kept this here to show the early structure of the project

    public Sound[] sounds;

    // called right before start method
    void Awake()
    {
        foreach(Sound s in sounds)
        {
            s.audioSource = gameObject.AddComponent<AudioSource>();
            // set the clip of the audio source equal to the current clip contained
            s.audioSource.clip = s.clip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.loop;
            s.audioSource.playOnAwake = s.playOnAwake;
        }// foreach
    }// Awake

    void Start()
    {
        
    }// Start

   public void Play(string name)
   {
        // Store the sound for the clip name entered 
        Sound s = Array.Find(sounds, sound => sound.name == name);

        s.audioSource.Play();
   }// Play
}// AudioManager

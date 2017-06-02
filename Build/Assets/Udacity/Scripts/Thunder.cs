using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour {

	public AudioSource thunder;

	// starting in 60 seconds a sound will be played every 60 seconds

 	void Start () {
		InvokeRepeating("playAudio", 3.0f,60.0f);
 	}

    void playAudio () {
		thunder.Play();
	}
 }

 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public AudioClip Walk;
    public AudioSource Source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;



    // Use this for initialization
    void Awake ()
    {
        Source = GetComponent<AudioSource>();
	}
	
	//void Input ()

    
    // Update is called once per frame
	void Update ()
    {
        Source.PlayOneShot(Walk, volHighRange); 
	}


    //https://unity3d.com/learn/tutorials/topics/audio/sound-effects-scripting
}

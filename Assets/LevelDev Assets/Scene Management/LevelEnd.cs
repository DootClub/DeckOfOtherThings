using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : SceneSwap
{
	public GameObject SelfTarget;
	public BasePlayerStats player;
    public Analytics DoTheCheckThing;

	// Use this for initialization
	void Start ()
	{
		player = FindObjectOfType<BasePlayerStats>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<BasePlayerStats>())
        {
            DoTheCheckThing = collision.gameObject.GetComponent<Analytics>();
            DoTheCheckThing.HitDoor();
			ChangeScene();
			print("BEEP");
		}
	}

}

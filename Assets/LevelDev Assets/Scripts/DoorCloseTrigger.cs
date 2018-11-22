using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//written by Luke
public class DoorCloseTrigger : MonoBehaviour
{
	public Door door;
	public BasePlayerStats player;
	public GameObject SelfTarget;

	// Use this for initialization
	void Start ()
	{
		door = FindObjectOfType<Door>();
		door.enabled = false;
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
			door.enabled = true;
			Destroy(SelfTarget);
			print("ASSASA");
		}
	}
}

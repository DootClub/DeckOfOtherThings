using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{

	public Vector2 prevPos;
	public Vector2 newPos;
	public Transform player;
	Animator animator;
	float timer = 1F;

	// Use this for initialization
	void Start ()
	{
		animator = GetComponent<Animator>();
		player = GetComponent<Transform>();
		newPos = player.localPosition;

	}
	
	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime;
		prevPos = player.localPosition;
		while(timer <= 0)
		{
			timer = 1F;
			newPos = player.localPosition;
			
			if(newPos.x <= prevPos.x)
			{
				print("moving left");
			}
			if(newPos.x >= prevPos.x)
			{
				print("moving right");
			}
		}


	}
}

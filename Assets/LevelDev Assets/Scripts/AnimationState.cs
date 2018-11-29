using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour
{

	public Vector2 prevPos;
	public Vector2 newPos;
	public Transform player;
	Animator animator;
	float timer = 0.2F;

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
		if(timer <= 0)
		{
			timer = 0.2F;
			newPos = player.localPosition;
			
			if(newPos.x <= prevPos.x)
			{
				print("moving left");
			}
			else
			{
				print("moving right");
			}
		}


	}
}

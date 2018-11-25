using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class TouchControls : MonoBehaviour
{
	// Target for faux touch control testing with mouse
	[SerializeField] private Transform target;

	private Vector2 targetPos;

	public float speed = 6f;

	Animator animator;

	void Start ()
	{
		// Sets targetPos to the player's current position
		targetPos = transform.position;

		// Gets the Animator component that is attached to the player
		animator = GetComponent<Animator>();
	}
	
	void Update ()
	{
		// Detect mouse position
		if (Input.GetMouseButtonDown(0))
		{
			// Sets targetPos to the clicked position
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.position = targetPos;
		}
		
		// Detect touch input
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			// Set touchPos to the touched position
			Vector2 touchPos = Input.GetTouch(0).deltaPosition;
			// Set targetPos to the touched positiong
			targetPos = Camera.main.ScreenToWorldPoint(touchPos);
			target.position = targetPos;
		}
		
		// If the player isn't at its target position, move it towards the target position
		if ((Vector2) transform.position != targetPos)
		{
			transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

			// Sets the player's animation to moving (done by Luke)
			animator.SetInteger("MovingLeft", 1);
		}

		else
		{
			// When not moving towards the target position, animation will go back to idle (done by Luke)
			animator.SetInteger("MovingLeft", 0);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
	

	[SerializeField] private Transform target;

	Animator animator;

	private Vector2 targetPos;

	private float speed = 6f;

	// public float speed = 0.01f;

	// Use this for initialization
	void Start ()
	{
		targetPos = transform.position;
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//The below line creates an error, apparently the variable "target" is not defined.
			//Commenting it out doesn't break anything so *shrug*
			//target.position = targetPos;
		}
		

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector2 touchPos = Input.GetTouch(0).deltaPosition;
			targetPos = Camera.main.ScreenToWorldPoint(touchPos);
			target.position = targetPos;
		}
		

		if ((Vector2) transform.position != targetPos)
		{
			transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
			//sets the player's animation to moving (done by Luke)
			animator.SetInteger("MovingLeft", 1);
		}
		else
		{
			//When not moving towards the target position, animation will go back to idle (done by Luke)
			animator.SetInteger("MovingLeft", 0);
		}

		
	}
}

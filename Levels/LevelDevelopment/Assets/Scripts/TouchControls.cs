using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
	// private Rigidbody2D playerCharacter;

	[SerializeField] private Transform target;

	private Vector2 targetPos;

	private float speed = 6f;

	// public float speed = 0.01f;

	// Use this for initialization
	void Start ()
	{
		targetPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.position = targetPos;
		}

		if ((Vector2) transform.position != targetPos)
		{
			transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
		}
	}
}

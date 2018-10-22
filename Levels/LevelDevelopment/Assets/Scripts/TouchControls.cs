using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour
{
	private Rigidbody2D playerCharacter;

	// public float speed = 0.01f;

	// Use this for initialization
	void Start ()
	{
		playerCharacter = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			// Get movement of finger since last frame
			Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
				
			// Move Character across X and Y planes
			playerCharacter.transform.Translate(-touchPosition.x * speed, -touchPosition.y * speed, 0);
		}*/

		if (Input.GetMouseButtonDown(0))
		{
			OnMouseDown();
		}
	}

	void OnMouseDown ()
	{
		RaycastHit hit;

		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
		{
			playerCharacter.transform.position = hit.point;
		}
		/*Get movement of finger since last frame
		Vector2 mousePosition = Input.mousePosition;

		// Move Character across X and Y planes
		playerCharacter.transform.Translate(-mousePosition.x * speed, -mousePosition.y * speed, 0);

		Debug.Log("It works!");*/
	}
}

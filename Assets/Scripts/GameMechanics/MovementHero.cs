using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHero : MonoBehaviour
{

	Rigidbody2D rbody;
	Animator anim;

	public float speed;

	private Vector2 touchOrigin = -Vector2.one;

	// Use this for initialization
	void Start()
	{

		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update()
	{



//#if UNITY_STANDALONE || UNITY_WEBPLAYER

		Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

		//if (movement_vector != Vector2.zero)
		//{
		//	anim.SetBool("walking", true);
		//	anim.SetFloat("input_x", movement_vector.x);
		//	anim.SetFloat("input_y", movement_vector.y);
		//}
		//else
		//{
		//	anim.SetBool("walking", false);
		//}

		//rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * speed);

//#else

		int horizontal = 0;
		int vertical = 0;

		horizontal = (int)(Input.GetAxisRaw("Horizontal"));
		vertical = (int)(Input.GetAxisRaw("Vertical"));

		if (Input.touchCount > 0)
		{
			Debug.Log("Bumchums");

			Touch myTouch = Input.touches[0];

			if (myTouch.phase == TouchPhase.Began)
			{
				touchOrigin = myTouch.position;
			}
			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
			{
				Vector2 touchEnd = myTouch.position;
				float x = touchEnd.x - touchOrigin.x;
				float y = touchEnd.y - touchOrigin.y;
				touchOrigin.x = -1;


				Debug.Log("FoundLocation");

				if (Mathf.Abs(x) > Mathf.Abs(y))
				{
					horizontal = x > 0 ? 1 : -1;
				}
				else
				{
					vertical = y > 0 ? 1 : -1;
				}

			}
		}

//#endif

		if (horizontal != 0 || vertical != 0)
		{
			Debug.Log("YOYO");
		}
	}
}
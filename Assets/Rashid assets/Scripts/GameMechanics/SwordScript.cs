using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

	public string targetTag;
	Animator anim;
	public bool attacking;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		attacking = true;
		Debug.Log("Yes");

		anim.SetBool("attacking", true);


	}

	private void OnTriggerExit2D(Collider2D other)
	{
		attacking = false;
		Debug.Log("No");

		anim.SetBool("attacking", false);

	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RayFeelers : MonoBehaviour
{
    public event Action PlayerSeen;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //RaycastHit2D hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 10, Color.green);
        if(Physics2D.Raycast(transform.position, transform.right, 10))
        {
            Debug.Log("Hit");
            PlayerSeen();
        }
	}
}

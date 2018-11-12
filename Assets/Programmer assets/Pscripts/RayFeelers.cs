using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RayFeelers : MonoBehaviour // Venus
{
    public int RaycastDistance;
	
	// Update is called once per frame
	void Update ()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * RaycastDistance, Color.green);
        if(Physics2D.Raycast(transform.position, transform.right, RaycastDistance))
        {
            Debug.Log("Hit");
            //PlayerSeen();
        }
	}
}

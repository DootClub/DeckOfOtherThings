using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
    // Setting up variables...
    private Vector2 SpeedVector;
    //private GameObject ;

    public float Speed;
    public float MaxDistance;
    public Vector2 StartPos;
    public event Action<int> HitPlayer;

	// Use this for initialization
	void Start ()
    {
        SpeedVector.x = Speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(SpeedVector);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
    }
}

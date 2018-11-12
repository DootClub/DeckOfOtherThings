using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour // Venus
{
    // Setting up variables...
    private Vector2 _speedVector;
    //private GameObject ;

    public float Speed;
    public float DespawnTime;
    //public float MaxDistance;
    //public Vector2 StartPos;
    public event Action<int> HitPlayer;
    public GameObject Self;

	// Use this for initialization
	void Start ()
    {
        _speedVector.x = Speed;
        Invoke("Despawn", DespawnTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(_speedVector);
        //if (transform.t)
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Despawn();
        }
    }

    void Despawn()
    {
        Destroy(Self);
    }
}

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
    public float DespawnTime;
    //public float MaxDistance;
    //public Vector2 StartPos;
    public event Action<int> HitPlayer;
    public GameObject Self;

	// Use this for initialization
	void Start ()
    {
        SpeedVector.x = Speed;
        Invoke("Despawn", DespawnTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(SpeedVector);
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

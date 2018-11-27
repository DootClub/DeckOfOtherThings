using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour // Venus
{
    // Setting up variables...
    //private Vector2 _speedVector;

    public float Speed;
    public float DespawnTime;
    public event Action<int> HitPlayer;

	// Use this for initialization
	void Start ()
    {
        //FindObjectOfType<baseCard>().SomeEvent += SetSpeed;
        //_speedVector.x = Speed;
        Invoke("Despawn", DespawnTime);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    //GetComponent<Rigidbody2D>().velocity = _speedVector;
	    //GetComponent<Rigidbody2D>().AddRelativeForce(_speedVector);
        transform.Translate((Vector3.right*Time.deltaTime*Speed));
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
        Destroy(gameObject);
    }

    /*void SetSpeed(float speed)
    {
        _speedVector.x = speed;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    //public bool Shooting = true;
    public float FireRate;
    public GameObject ObjectToSpawn;

    private float LastFired;
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time - LastFired > 1/(FireRate/10))
        {
            LastFired = Time.time;
            Shoot();
        }
        //Invoke("Shoot", ShootDelay);
	}

    void Shoot()
    {
        Instantiate(ObjectToSpawn, GetComponent<Transform>());
    }
}

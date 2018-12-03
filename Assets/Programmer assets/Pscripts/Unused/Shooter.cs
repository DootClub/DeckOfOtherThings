﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour    // Venus
{
    //public bool Shooting = true;
    public float FireRate;
    public GameObject ObjectToSpawn;

    private float LastFired;

    void Start()
    {
        /*foreach(RayFeelers feeler in FindObjectsOfType<RayFeelers>())
        {
            feeler.PlayerSeen += Shoot;
        }*/
        //FindObjectOfType<BaseCardScript>().SomeEvent += SetDPS;
    }

    // Update is called once per frame
    void Update ()
    {
        //Invoke("Shoot", ShootDelay);
    }

    public void Shoot()
    {
        if (Time.time - LastFired > 1 / (FireRate / 10))
        {
            LastFired = Time.time;
            //Shoot();
            Instantiate(ObjectToSpawn, GetComponent<Transform>());
        }
    }

    void SetDPS(int fireRate)
    {
        FireRate = fireRate;
    }
}

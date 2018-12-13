using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour    // Venus
{
    public float FireRate;
    public GameObject ObjectToSpawn;
    public bool SwitchOn = false;

    private float LastFired;

    void Start()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        if(SwitchOn == true)
        {
            if (Time.time - LastFired > 1 / (FireRate / 10))
            {
                LastFired = Time.time;
                Instantiate(ObjectToSpawn, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
            }
        }
    }
}

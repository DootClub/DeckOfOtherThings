using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCircle : MonoBehaviour
{
    public float FireRate;
    public GameObject Projectile;

    private float LastFired;
    public Vector3 DisplaceVector;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Hit!");
        if (Time.time - LastFired > 1 / (FireRate / 10))
        {
            LastFired = Time.time;
            //Shoot();
            Instantiate(Projectile, GetComponent<Transform>());
        }
        Instantiate(Projectile, collision.GetComponent<Transform>());
    }
}

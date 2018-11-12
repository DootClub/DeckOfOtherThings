using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCircle : MonoBehaviour   // Venus
{
    //public float FireRate;
    //public GameObject Shooter;

    /*private float LastFired;
    public Vector3 DisplaceVector;*/

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        transform.right = other.transform.position - transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Quaternion test = collision.GetComponent<Transform>().rotation;
        //Debug.Log("Hit!");
        /*if (Time.time - LastFired > 1 / (FireRate / 10))
        {
            LastFired = Time.time;
            //Shoot();
            Instantiate(Projectile, GetComponent<Transform>());
        }*/
        //Instantiate(Shooter, collision.GetComponent<Transform>().position, );
        //Vector3 OwnPos = GetComponent<Transform>();
        /*Vector3.RotateTowards(transform.position, collision.transform.position, 0, Mathf.PI);
        Vector2.*/
        transform.right = collision.transform.position - transform.position;
    }
}

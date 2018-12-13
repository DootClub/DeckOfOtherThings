using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VisionCircle : MonoBehaviour   // Venus
{
    public event Action<bool> SwitchEvent;
    public GameObject shooter;

    // Use this for initialization
    void Start()
    {
        //shooter.GetComponent<Shooter>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (SwitchEvent != null) SwitchEvent(true);
        if (collision.tag == "Enemy")
        {
            transform.right = collision.transform.position - transform.position;
            shooter.GetComponent<Shooter>().SwitchOn = true;
            Debug.Log("True");
        }

        //shooter.GetComponent<Shooter>().enabled = true;
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            transform.right = other.transform.position - transform.position;
            shooter.GetComponent<Shooter>().SwitchOn = true;
        }
        else
        {
            shooter.GetComponent<Shooter>().SwitchOn = false;
        }
        //shooter.GetComponent<Shooter>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            //transform.right = collision.transform.position - transform.position;
            shooter.GetComponent<Shooter>().SwitchOn = false;
        }
    }
}

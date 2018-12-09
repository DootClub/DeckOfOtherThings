using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePlayerStats : MonoBehaviour
{

    //Variables



    //Functions
    public void Die()
    {
        if (GetComponent<Rigidbody2D>() != null)
        {
            Destroy(GetComponent<Rigidbody2D>());
        }

        if (GetComponent<BoxCollider2D>() != null)
        {
            Destroy(GetComponent<BoxCollider2D>());
        }

        if (GetComponent<SpriteRenderer>() != null)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }

        GetComponent<TouchControls>().enabled = false;
    }

    // Use this for initialization
    void Start()
    {
    GetComponent<Health>().OnDeath += Die;
    }

    // Update is called once per frame
    void Update()
    {

    }

}

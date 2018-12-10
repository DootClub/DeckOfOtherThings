using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour // Venus
{
    [SerializeField]
    private int healthAmount;

    public int HealthAmount
    {
        get
        {
            return healthAmount;
        }

        set
        {
            Change(value - healthAmount); // Stupid HACK
            healthAmount = value;
        }
    }

    public event Action OnDeath;
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public int Change(int difference)
    {
        int Total;
        Total = healthAmount + difference;
        if (Total <= 0)
        {
            if (OnDeath != null)
            {
                OnDeath();
            }
        }
        return Total;
    }
}

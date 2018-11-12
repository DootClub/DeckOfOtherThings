using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour // Venus
{
    private int _amount;

    public int HealthAmount;
    public event Action OnDeath;
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    int Change(int difference)
    {
        int Total;
        Total = _amount + difference;
        if(Total <= 0)
        {
            if (OnDeath != null)
            {
                OnDeath();
            }
        }
        return Total;
    }
}

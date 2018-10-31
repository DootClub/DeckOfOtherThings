using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    private int Amount;

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

    int Change(int Difference)
    {
        int Total;
        Total = Amount + Difference;
        if(Total <= 0)
        {
            OnDeath();
        }
        return Total;
    }
}

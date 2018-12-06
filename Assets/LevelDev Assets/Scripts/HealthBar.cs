using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//written by Luke
public class HealthBar : MonoBehaviour
{
	public Health playerHP;
	public Slider bar;
	public float HPamount;
	public float value;

	// Use this for initialization
	void Start ()
	{
		playerHP = GetComponentInParent<Health>();
		//playerHP = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		bar.value = playerHP.HealthAmount;
        // TODO: CAM: Removed this, put it in a proper GameManager object. 
        /*
                if(bar.value <= 0)
                {
                    SceneManager.LoadScene("LoseScreen");
                }
        */
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//written by Luke
public class MoveTowardsPlayer : MonoBehaviour
{
	public float moveSpeed;
    public float moveSpeedBackup;
    public bool isPause;
	public BasePlayerStats player;
	public Health opposingHealth;
	public GameObject SelfTarget;
	public int damage;
    public Analytics CustomAnalyser;
    public PauseMenu Pauser;



    public AudioClip clip;
    public AudioSource Source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    // Use this for initialization
    void Start ()
	{
		player = FindObjectOfType<BasePlayerStats>();
		opposingHealth = player.GetComponent<Health>();

        //Pauser = FindObjectOfType<PauseMenu>();

        FindObjectOfType<PauseMenu>().BeenPaused += onPause;
        isPause = false;

        moveSpeed = moveSpeedBackup;
        GetComponent<Health>().OnDeath += Die;
    }

    // Update is called once per frame
    void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
        

    }



	
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<BasePlayerStats>())
        {
			print("I'VE COLLIDEDDDD");
            GetComponent<Health>().Change(-100);
			opposingHealth.HealthAmount -= damage;
		}

		if(collision.tag == "Projectile")
		{
			SelfTarget.GetComponent<Health>().HealthAmount -= 10;
			print("ouch bro");
		}
	}

    public void onPause()
    {
        if (isPause)
        {
            
            isPause = false;
            moveSpeed = moveSpeedBackup;
        }
        else
        {
            
            isPause = true;
            moveSpeed = 0;
        }
    }

	public void Die()
    {
		Destroy(SelfTarget);

//		  Destroy(GetComponent<Rigidbody2D>());
//        //Destroy(GetComponent<BoxCollider2D>());
//        BoxCollider2D[] Boxes = GetComponents<BoxCollider2D>();
//        foreach (BoxCollider2D thing in Boxes)
//        {
//            Destroy(thing);
//        }
//        GetComponent<SpriteRenderer>().enabled = false;
//        StartCoroutine(DestroyEnemy());
        
    }

   // private IEnumerator DestroyEnemy()
  //  {
       // opposingHealth.HealthAmount -= damage;
       // yield return new WaitForSeconds(2);
        
  //  }
}

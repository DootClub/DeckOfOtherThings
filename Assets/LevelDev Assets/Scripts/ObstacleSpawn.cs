using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//written by Luke
public class ObstacleSpawn : MonoBehaviour
{
	public GameObject self;
	public GameObject[] obstaclePrefab;
	public GameObject prefab;
	public GameObject room;


	// Use this for initialization
	void Start ()
	{

		room = self.transform.parent.gameObject;

		prefab = obstaclePrefab[Random.Range(0, obstaclePrefab.Length)];

		Transform localpos = room.transform;

		Instantiate(prefab, localpos);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

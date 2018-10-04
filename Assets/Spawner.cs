using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int MapSize;

    private Vector3 SpawnLocation;

	// Use this for initialization
	void Start ()
    {
		for(int i = 0; i <= MapSize; i++)
        {
            for (int j = 0; j <= MapSize; j++)
            {
                SpawnLocation.x = i;
                Instantiate(ObjectToSpawn, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ObjectToSpawn);
        }
	}
}

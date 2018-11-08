using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
	public enum ExitNames
	{
		North,
		South,
		West,
		East
	}

	public ExitNames exits;

//	public bool hasEastExit;
//	public bool hasWestExit;
//	public bool hasNorthExit;
//	public bool hasSouthExit;

	PCGMAIN managerScript;


	public Transform southExit;
	public Transform northExit;

	public int luck;

	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void VerticalCorridor()
	{
		for (int chance = Random.Range(0, 3); chance > Random.Range(0, 3);)
		{
			managerScript.GenerateVerticalCorridor();
		}
	}
}

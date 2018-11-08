﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTests : MonoBehaviour
{
	public List<GameObject> levelPrefabs;

	// Use this for initialization
	void Start()
	{
		// Check all prefabs
		foreach (GameObject item in levelPrefabs)
		{

			// Get all children to find all exits
			Exit[] exits = item.GetComponentsInChildren<Exit>();

			print(item.name);
			// Loop through all exits looking for specific combinations
			foreach (Exit exit in exits)
			{
				switch (exit.exits)
				{
					case Exit.ExitNames.North:
						print("N Exit exists");
						break;
					case Exit.ExitNames.South:
						print("S Exit exists");
						break;
					case Exit.ExitNames.West:
						print("W Exit exists");
						break;
					case Exit.ExitNames.East:
						print("E Exit exists");
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
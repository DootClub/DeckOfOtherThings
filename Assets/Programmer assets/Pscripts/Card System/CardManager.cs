using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Written by Tegan Walsh-Jones
public class CardManager : CardBase
{

	//public CardBase[] AllCards = new CardBase[3];

	// public List<CardBase> allCards = new List<CardBase>();

	public GameObject currentCard;

	// Use this for initialization
	void Start ()
	{
		List<CardBase> allCards = new List<CardBase>();

		allCards.Add(lonesome);
		allCards.Add(bulwark);
		allCards.Add(dreamer);

		/*
		foreach (CardBase card in allCards)
		{
			print(card.playerHealth);
		}
		*/
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

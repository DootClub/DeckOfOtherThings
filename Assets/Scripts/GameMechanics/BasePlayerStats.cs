using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePlayerStats : MonoBehaviour {


	public MajorCard majorCard;
	public MinorCard minorCard;

	public float health;
	public float sp;

	public float str;
	public float dex;
	public float cha;
	
	public float damageOutput;
	public float attackRate;
	public float defense;
	

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {


	}

	public void UpdateDeck()
	{
		attackRate = 0;
		damageOutput = 0;
		defense = 0;

		attackRate = AttackRate;
		damageOutput = DamageOutput;
		defense = Defense;
	}

	public float DamageOutput
	{
		get
		{
			return str + majorCard.strC * minorCard.damageOutput;
		}
	}

	public float AttackRate
	{

		get
		{
			return dex + majorCard.dexC * minorCard.attackRate;
		}

	}

	public float Defense
	{
		get
		{
			return cha + majorCard.chaC * minorCard.defense;
		}
	}
}

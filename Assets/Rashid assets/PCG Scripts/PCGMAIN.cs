using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCGMAIN : MonoBehaviour {

	Exit exit;
	MidExit exitMid;
	GameManager gm;

	public PCGMAIN nextSegment;

	public Vector2 newExit;

	public Vector2 entryPoint;
	public GameObject[] tilePrefabs;

	public Transform exit1;
	public Transform exit2;
	public Transform exit3;

	public Transform[] exitTran;


	public float vertical;
	public float horizontal;

	public bool leftExit;
	public bool rightExit;

	public bool set;

	public int room;
	public int corridor;

	public int capacity;

	public GameObject prefab1;
	public GameObject prefab2;
	public GameObject prefab3;
	public GameObject prefab4;
	public GameObject prefab5;

	public GameObject[] prefab;

	public bool corridor1;
	public bool corridor2;
	public bool corridor3;
	public bool corridorClose;

	public List<GameObject> myList = new List<GameObject>();
	public List<Transform> exitList = new List<Transform>();

	// Use this for initialization
	void Start () {

		if (rightExit && set)
		{
			newExit = prefab[4].GetComponent<MidExit>().rightWing.transform.position;
		}
			
		else if (!rightExit && set)
		{
			newExit = prefab[4].GetComponent<MidExit>().leftWing.transform.position;
		}
			

		if (!set)
		for (int level = 0; level < room; level ++ )
		{
			Debug.Log("Hey");

			prefab1 = Instantiate(tilePrefabs[0], new Vector2(newExit.x, newExit.y), Quaternion.identity);

			prefab2 = Instantiate(tilePrefabs[1], new Vector2(newExit.x += horizontal, newExit.y), Quaternion.identity);

			prefab3 = Instantiate(tilePrefabs[2], new Vector2(newExit.x += horizontal, newExit.y), Quaternion.identity);

			myList.Add(prefab1);
			myList.Add(prefab2);
			myList.Add(prefab3);

			//exit.VerticalCorridor();

			corridor1 = true;
			corridor2 = true;
			corridor3 = true;

			GenerateVerticalCorridor();

		}
		
	}

	public void NewEntry()
	{
		for (int level = 0; level < room; level++)
		{
			Debug.Log("HeyAgain");

			if (rightExit)
			{
				prefab[3] = Instantiate(tilePrefabs[0], new Vector2(newExit.x + 3, newExit.y), Quaternion.identity);

				prefab[4] = Instantiate(tilePrefabs[1], new Vector2(newExit.x += horizontal + 3, newExit.y), Quaternion.identity);

				prefab[5] = Instantiate(tilePrefabs[2], new Vector2(newExit.x += horizontal, newExit.y), Quaternion.identity);

				set = true;

			}
			else
			{
				prefab[3] = Instantiate(tilePrefabs[0], new Vector2(newExit.x, newExit.y), Quaternion.identity);

				prefab[4] = Instantiate(tilePrefabs[1], new Vector2(newExit.x -= horizontal, newExit.y), Quaternion.identity);

				prefab[5] = Instantiate(tilePrefabs[2], new Vector2(newExit.x -= horizontal, newExit.y), Quaternion.identity);

				set = true;

				
			}

			myList.Add(prefab[3]);
			myList.Add(prefab[4]);
			myList.Add(prefab[5]);

			//exit.VerticalCorridor();

			corridor1 = true;
			corridor2 = true;
			corridor3 = true;

			if (set && capacity < 1)
			{
				Debug.Log("Fuck");
				nextSegment.gameObject.SetActive(true);
				capacity++;

				set = false;
			}
		}
	}


	public void GenerateVerticalCorridor ()
	{
		Debug.Log("YUP");

		corridor++;

		if (!corridorClose)
		{
			Debug.Log("Yeye");

			if (corridor1)
			{

				newExit = prefab2.GetComponent<Exit>().southExit.transform.position;

				prefab4 = Instantiate(tilePrefabs[3], new Vector2(newExit.x, newExit.y), Quaternion.identity);

				corridor1 = false;

				myList.Add(prefab4);

			}

			if (corridor2 && Random.Range(0, 10) > Random.Range(0, 10))
			{

				newExit = prefab4.GetComponent<Exit>().northExit.transform.position;

				prefab4 = Instantiate(tilePrefabs[3], new Vector2(newExit.x, newExit.y), Quaternion.identity);

				corridor2 = false;

				myList.Add(prefab4);

			}
			else
			{
				corridor2 = false;
			}


			if (corridor3 && Random.Range(0, 10) > Random.Range(0, 10))
			{

				newExit = prefab4.GetComponent<Exit>().northExit.transform.position;
				
				prefab4 = Instantiate(tilePrefabs[3], new Vector2(newExit.x, newExit.y), Quaternion.identity);

				corridor3 = false;

				myList.Add(prefab4);
			}
			else
			{
				corridor3 = false;
			}

			if (corridor1 == false && corridor2 == false && corridor3 == false)
			{
				GenerateHorizontalCorridor();
			}

		}		

	}

	public void GenerateHorizontalCorridor()
	{

		Debug.Log("Working");

		corridorClose = true;

		newExit = prefab4.GetComponent<Exit>().northExit.transform.position;

		for (int i = 0; i < 1; i++)
		{
			prefab5 = Instantiate(tilePrefabs[4], new Vector2(newExit.x, newExit.y), Quaternion.identity);
			exit1 = prefab5.GetComponent<MidExit>().leftWing;
			exit2 = prefab5.GetComponent<MidExit>().midWing;
			exit3 = prefab5.GetComponent<MidExit>().rightWing;
			exitList.Add(exit1);
			exitList.Add(exit2);
			exitList.Add(exit3);
		}


		if (prefab5 != null)
		{

			if (Random.Range(0,10) < Random.Range(0, 10))
			{
				prefab5.gameObject.transform.position = new Vector2(prefab5.gameObject.transform.position.x - 2, prefab5.gameObject.transform.position.y);
				leftExit = true;
				Debug.Log("YOYO");
				GenerateRandomPiece();
			}
			else 
			{
				Debug.Log("HOHO");
				rightExit = true;
				prefab5.gameObject.transform.position = new Vector2(prefab5.gameObject.transform.position.x + 2, prefab5.gameObject.transform.position.y);
				GenerateRandomPiece();
			}

		}
	}

	public void GenerateRandomPiece()
	{
		for (int length = 0; length < 1; length++)
		{
			if (rightExit)
			{
				newExit = prefab5.GetComponent<MidExit>().rightWing.transform.position;

				Debug.Log("NewRight");
				prefab[1] = Instantiate(tilePrefabs[4], new Vector2(newExit.x + 2, newExit.y), Quaternion.identity);
				exitTran[0] = prefab[1].GetComponent<MidExit>().leftWing;
				exitTran[1] = prefab[1].GetComponent<MidExit>().midWing;
				exitTran[2] = prefab[1].GetComponent<MidExit>().rightWing;
				exitList.Add(exitTran[0]);
				exitList.Add(exitTran[1]);
				exitList.Add(exitTran[2]);

				if (Random.Range(0, 10) > Random.Range(0, 10))
				{
					newExit = exitTran[0].transform.position;
				}
				else
				{
					newExit = exitTran[1].transform.position;
				}

				NewEntry();

			}
			else
			{
				newExit = prefab5.GetComponent<MidExit>().leftWing.transform.position;
				Debug.Log("NewLeft");
				prefab[2] = Instantiate(tilePrefabs[3], new Vector2(newExit.x, newExit.y - 1), Quaternion.identity);
				exitTran[0] = prefab[2].GetComponent<Exit>().northExit;
				exitTran[1] = prefab[2].GetComponent<Exit>().southExit;
				exitList.Add(exitTran[0]);
				exitList.Add(exitTran[1]);

				newExit = prefab[2].GetComponent<Exit>().northExit.transform.position;

				NewEntry();

			}
		}
	}

}

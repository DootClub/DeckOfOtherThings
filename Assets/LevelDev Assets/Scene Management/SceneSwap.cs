using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
	public string next;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void ChangeScene()
	{
		SceneManager.LoadScene(next);
	}

	public void Quit()
	{
		Application.Quit();
	}
}

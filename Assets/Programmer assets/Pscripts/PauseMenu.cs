using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

// Written by Tegan Walsh-Jones
public class PauseMenu : MonoBehaviour
{
	public Canvas pauseMenu;

	public static bool gameIsPaused = false;

	[SerializeField] private Button pauseButton;

    public event Action BeenPaused;

	// Use this for initialization
	void Start()
	{
		GetComponent<Canvas>();

		pauseMenu.GetComponent<Canvas>().enabled = false;

		pauseButton.onClick.AddListener(PauseOnClick);
	}

	// Update is called once per frame
	void Update ()
	{
		
	}

	void PauseOnClick ()
    {
        

		if (gameIsPaused)
		{
			Resume();
		}

		else
		{
			Pause();
		}
	}

	public void Resume ()
	{
		pauseMenu.GetComponent<Canvas>().enabled = false;
		Time.timeScale = 1f;
        gameIsPaused = false;
        BeenPaused();
    }

	public void Pause ()
	{
		pauseMenu.GetComponent<Canvas>().enabled = true;
		Time.timeScale = 0f;
		gameIsPaused = true;
        BeenPaused();
    }

	public void LoadMainMenu ()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitApp()
	{
		Application.Quit();
	}
}

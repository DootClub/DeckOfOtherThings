using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;


    // Use this for initialization
    void Start()
    {
        player.GetComponent<Health>().OnDeath += Screen_OnDeath;

    }

    public void Screen_OnDeath()
    {
        StartCoroutine( LoadLoseScreen() );
    }

    private IEnumerator LoadLoseScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("LoseScreen");
    }

    // Update is called once per frame
    void Update ()
    {
 //       if(HealthBar.value <= 0)
        {
            //Scene.LoadScene("LoseScreen");
        }

	}
}

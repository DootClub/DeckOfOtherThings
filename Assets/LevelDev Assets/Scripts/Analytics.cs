using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Analytics : MonoBehaviour
{
    //Variables
    private int EnemyCount;
    private bool Death;

    //Functions

    public void DoAnalyse()
    {
        if (Death)
        {
            print("I deaded");
        }
        else
        {
            print("Enemy Count = " + EnemyCount);
        }
    }

    public void HitEnemy()
    {
        EnemyCount = EnemyCount + 1;
    }

    public void HitDoor()
    {
        Death = false;
        DoAnalyse();
        EnemyCount = 0;
    }

    public void HitDeath()
    {
        Death = true;
        DoAnalyse();
    }

    // Use this for initialization
    void Start()
    {
        EnemyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

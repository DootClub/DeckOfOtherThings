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
            UnityEngine.Analytics.AnalyticsEvent.Custom("Death", new Dictionary<string, object>
            {

            });
        }
        else
        {
            UnityEngine.Analytics.AnalyticsEvent.Custom("LevelComplete", new Dictionary<string, object>
            {
                {"Enemies Hit", EnemyCount}
            });
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

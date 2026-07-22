using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;



public class EnemySpawner : MonoBehaviour
{

    public GameObject Spawnthis;
    public GameObject Spawnthis2;

    public ScoreManager SM;
    public GameTimeManager GTM;

    public int maxenemies;
    public int initenemies;
    float score;
    int numenemies = 0;
 //TODO: impelement this
    public void killedenemy()
    {
        numenemies -=1;
    }
    // Start is called before the first frame update
    void Start()
    {
    if (initenemies > maxenemies)
        {
            Debug.LogError("Inital enemies is greater than maxmimum enemies");
        }

        if(maxenemies >= int.MaxValue/2)
        {
            Debug.LogWarning("this number of enemies is likely to cause lag");
        }else if (maxenemies < 0)
        {
            maxenemies = maxenemies *-1;
            Debug.LogWarning("Do not set max enemies to a negative value.");
        }else if  (maxenemies == 0)
        {
            if (initenemies <= 0)
            {
                Debug.LogError("you must set a balue of initial enemies and max enemies.");
            }else
            {
            maxenemies = initenemies;
            Debug.LogError("Max enemies set to 0, please change the value.");
            }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = SM.getscore();
        if (score == 0)
        {
            for (int i = 0;i > initenemies; i++)
            {
                int rand = Random.Range(0,2); //detemines which type of enemy to spawn
                //TODO: enemy spawning
                numenemies += 1;
            }

        }
        else
        {
            if (!GTM.gettimerended())
            {
                if (numenemies <= maxenemies)
                {
                    for (int i = 0;i > initenemies + score/100; i++)
                {
                    int rand = Random.Range(0,2); //detemines which type of enemy to spawn
                    //TODO: enemy spawning
                    //note: ensure enemies do not overlap player somehow
                    numenemies += 1;
                }
                }
            }
        }
    }
}

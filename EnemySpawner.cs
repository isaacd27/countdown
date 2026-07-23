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

    [SerializeField]
    private float minTime;

    [SerializeField]
    private float maxTime;

private float timeTilSpawn;
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
    //
    void Awake()
    {

        SetTimeTilSpawn();
    /* if (initenemies > maxenemies)
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
           



        */
    }

    // Update is called once per frame
    void Update()
    {
        timeTilSpawn -= Time.deltaTime; //
        score = SM.getscore();
        if (score == 0)
        {
         
            if(timeTilSpawn <= 0)
                    {
                        int rand = Random.Range(0,2); //detemines which type of enemy to spawn
                        if (rand == 1)
                        {
                            Instantiate(Spawnthis,transform.position,quaternion.identity);
                            SetTimeTilSpawn();
                        }
                        else
                        {
                         Instantiate(Spawnthis2,transform.position,quaternion.identity);
                         SetTimeTilSpawn();   
                        }
        }
        else
        {
            if (!GTM.gettimerended())
            {
                if (numenemies <= maxenemies)
                {
                   if(timeTilSpawn <= 0)
                    {
                        int rand = Random.Range(0,2); //detemines which type of enemy to spawn
                        if (rand == 1)
                        {
                            Instantiate(Spawnthis,transform.position,quaternion.identity);
                            SetTimeTilSpawn();
                        }
                        else
                        {
                            Instantiate(Spawnthis2,transform.position,quaternion.identity);
                            SetTimeTilSpawn();  
                        }
                    }
                    
                    //TODO: enemy spawning
                    //note: ensure enemies do not overlap player somehow
                   // numenemies += 1;
                
                }
            }
        }
        }
    }

    private void SetTimeTilSpawn()
    {
        timeTilSpawn = Random.Range(minTime,maxTime);
    }
}

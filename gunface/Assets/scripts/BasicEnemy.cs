using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BasicEnemy : MonoBehaviour
{
    //public GameObject coinprefab;
    public GameObject Player;
    public float speed = 0.3f;

    public int hp = 1;
    public float time;

    public ScoreManager sm;
    public GameTimeManager gtm;
    
    public int score;

    public GameObject Pdrop, PAdrop, RDrop,RAdrop, SDrop, SADrop, speeddrop, timedrop; 
    //refers to the drops an enemy can have

    // Start is called before the first frame update

   
    void Start()
    {
         //todo: make sure score and GT managers are set in start, for instanition
        gtm = GameObject.Find("TimerManager").GetComponent<GameTimeManager>();
        sm = GameObject.Find("scoremanager").GetComponent<ScoreManager>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player)
        {
            Movement();
        }

        //if (hp <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }

    protected virtual void Movement()
    {
        if (this.transform.position.x > Player.transform.position.x)
        {
            //transform.localScale = new Vector3((float)-1.943782, transform.localScale.y);
            transform.position += new Vector3(-speed * Time.deltaTime, 0f);
        }
        else if (this.transform.position.x < Player.transform.position.x)
        {
            //transform.localScale = new Vector3((float)1.943782, transform.localScale.y);
            transform.position += new Vector3(speed * Time.deltaTime, 0f);
        }
        else if (this.transform.position.x == Player.transform.position.x)
        {
            if (this.transform.position.y > Player.transform.position.y)
            {
                transform.position += new Vector3(0f, -speed * Time.deltaTime);
            }
            else if (transform.position.y < Player.transform.position.y)
            {
                transform.position += new Vector3(0f, speed * Time.deltaTime);
            }
        }
    }

    public void kill()
    {
        Debug.Log("hit");
        hp -= 1;

        sm.addScore(score);
        gtm.addTimerTime(time);


        //copy this code to chaser
        int rand = UnityEngine.Random.Range(0, 9);

        switch (rand)
        {
            case 0:
                GameObject.Instantiate(Pdrop, this.transform.position, quaternion.identity);
                break;
            case 1:
                GameObject.Instantiate(PAdrop, this.transform.position, quaternion.identity);

                break;
            case 2:
                GameObject.Instantiate(RDrop, this.transform.position, quaternion.identity);

                break;

            case 3:
                GameObject.Instantiate(RAdrop, this.transform.position, quaternion.identity);

                break;

            case 4:
                GameObject.Instantiate(SDrop, this.transform.position, quaternion.identity);
                break;

            case 5:
                GameObject.Instantiate(SADrop, this.transform.position, quaternion.identity);

                break;

            case 6:
                GameObject.Instantiate(speeddrop, this.transform.position, quaternion.identity);

                break;

            case 7:
                GameObject.Instantiate(timedrop, this.transform.position, quaternion.identity);

                break;

                //you get the idea
        }

        //if (this.gameObject.CompareTag("Danger"))
        //{
        //    Destroy(this.gameObject);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision detected");
        Debug.Log(collision.gameObject.name);

        //Debug.Log(collision.gameObject.name);
        //if (collision.gameObject.CompareTag("Projectile"))
        //{
        //    Debug.Log("hit");
        //    hp -= 1;

        //    if (hp <= 0)
        //    {
        //        //temp = GameObject.Instantiate(coinprefab, new Vector3(this.transform.position.x + d.x, this.transform.position.y + d.y), this.transform.rotation);

        // this feels a lil dangerous if it happens first..
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
        }

        sm.addScore(score);
        gtm.addTimerTime(time);
        //copy this code to chaser
        int rand = UnityEngine.Random.Range(0, 9);

        switch (rand)
        {
            case 0:
                GameObject.Instantiate(Pdrop, this.transform.position, quaternion.identity);
                break;
            case 1:
                GameObject.Instantiate(PAdrop, this.transform.position, quaternion.identity);

                break;
            case 2:
                GameObject.Instantiate(RDrop, this.transform.position, quaternion.identity);

                break;

            case 3:
                GameObject.Instantiate(RAdrop, this.transform.position, quaternion.identity);

                break;

            case 4:
                GameObject.Instantiate(SDrop, this.transform.position, quaternion.identity);
                break;

            case 5:
                GameObject.Instantiate(SADrop, this.transform.position, quaternion.identity);

                break;

            case 6:
                GameObject.Instantiate(speeddrop, this.transform.position, quaternion.identity);

                break;

            case 7:
                GameObject.Instantiate(timedrop, this.transform.position, quaternion.identity);

                break;

                //you get the idea
        }
    }
}
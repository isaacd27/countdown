using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : BasicEnemy
{
    //public float time;
    //public int score;
    //public ScoreManager sm;
    //public GameTimeManager gtm;

   // public int hp = 1;
    // Start is called before the first frame update
    void Start()
    {
        gtm = GameObject.Find("TimerManager").GetComponent<GameTimeManager>();
        sm = GameObject.Find("scoremanager").GetComponent<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    protected override void Movement()
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

        if (this.transform.position.y > Player.transform.position.y)
        {
            transform.position += new Vector3(0f, -speed * Time.deltaTime);
        }
        else if (transform.position.y < Player.transform.position.y)
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
            hp -= 1;
                if(hp <= 0)
        {
            sm.addScore(score);
            gtm.addTimerTime(time);
            int rand = UnityEngine.Random.Range(0,9);
                switch (rand)
                {
                    case 0:
                    GameObject.Instantiate(Pdrop,this.transform.position,Quaternion.identity);
                    break;
                    case 1:
                    GameObject.Instantiate(PAdrop,this.transform.position,Quaternion.identity);

                    break;
                    case 2:
                    GameObject.Instantiate(RDrop,this.transform.position,Quaternion.identity);

                    break;

                    case 3:
                    GameObject.Instantiate(RAdrop,this.transform.position,Quaternion.identity);

                    break;

                    case 4:
                    GameObject.Instantiate(SDrop,this.transform.position,Quaternion.identity);
                    break;

                    case 5:
                    GameObject.Instantiate(SADrop,this.transform.position,Quaternion.identity);

                    break;

                    case 6:
                    GameObject.Instantiate(speeddrop,this.transform.position,Quaternion.identity);

                    break;

                    case 7:
                    GameObject.Instantiate(timedrop,this.transform.position,Quaternion.identity);

                    break;

                    //you get the idea
                }

            Destroy(this.gameObject);
        }
            
    }
}





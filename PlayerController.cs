using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 

    public float moveSpeed = 5f;
    public GameTimeManager gtm;

    float speeduptimer;
    public float speedupfactor;

    Animator anim;

    int Wspeed;

 
    // Start is called before the first frame update
     void Awake()
    {
                anim = GetComponent<Animator>();


        Wspeed = Animator.StringToHash("walkingspeed");

       

    }

    public void SetSpeedTimer(float time)
    {
        speeduptimer = time;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        speeduptimer -= Time.deltaTime;

        if(movement != Vector3.zero)
        {
        anim.SetInteger(Wspeed,1);
        }
        else
        {
            anim.SetInteger(Wspeed,0);

        }

        // Debug.Log(IsGrounded());

        // if (tilemap.ContainsTile(tilemap.name("Player")))
        // {

        //  }
        if (!gtm.gettimerended())
        {
            if (speeduptimer < 0)
        {
                    transform.position += movement * Time.deltaTime * (moveSpeed *speedupfactor);

        }
            else
            {
            transform.position += movement * Time.deltaTime * moveSpeed;

            }

        }
    }
}


    
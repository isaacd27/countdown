using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 

    public float moveSpeed = 5f;
    public GameTimeManager gtm;

    float speeduptimer;
    public float speedupfactor;

    Animator anim;

    int Wspeed;

    public GameObject Resumemenu, paussemenu;
    bool paused;

 
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();


        //Wspeed = Animator.StringToHash("walkingspeed");

       

    }

    public void SetSpeedTimer(float time)
    {
        speeduptimer = time;
    }
    void Start()
    {
        
    }

    public void Puase()
    {
        paused = !paused;
    }

    // Update is called once per frame
    void Update()
    {
        if (paused)
        {
            Resumemenu.SetActive(false);
            paussemenu.SetActive(true);
        }else{
            Resumemenu.SetActive(true);
            paussemenu.SetActive(false);
        }

        if (gtm.gettimerended())
        {
        Resumemenu.SetActive(false);
        paussemenu.SetActive(false);    
        }


        if (Input.GetKeyDown(KeyCode.Escape) && !gtm.gettimerended()){
            Puase();
        }
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        speeduptimer -= Time.deltaTime;

        if (movement != Vector3.zero)
        {
            //anim.SetInteger(Wspeed,1);
			//anim.SetFloat(Wspeed,1);
            anim.speed = 1;
        }
        else
        {
            //anim.SetInteger(Wspeed,0);
            //anim.SetFloat(Wspeed,0);
            anim.speed = 0;

        }


        gtm.ispaused(paused);
        // Debug.Log(IsGrounded());

        // if (tilemap.ContainsTile(tilemap.name("Player")))
        // {

        //  }
        if (!gtm.gettimerended() && !paused)
        {
			
            if (speeduptimer < 0){
                    transform.position += movement * Time.deltaTime * (moveSpeed *speedupfactor);
            Debug.Log("sped up");

        
            }
			else
            {
                transform.position += movement * Time.deltaTime * moveSpeed;

            }

        }
    }
}




    
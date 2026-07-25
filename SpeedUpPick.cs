using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPick : MonoBehaviour
{

    public PlayerController PC;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        PC = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<GunFace>() != null)
        {
            PC.SetSpeedTimer(timer);
            //playsfx
            Destroy(this.gameObject);
        }

}

}

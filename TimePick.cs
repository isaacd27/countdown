using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePick : MonoBehaviour
{
    public GameTimeManager gtm;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
    gtm = GameObject.Find("TimerManager").GetComponent<GameTimeManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<GunFace>() != null)
        {
            gtm.addTimerTime(time);
            //playsfx
            Destroy(this.gameObject);
        }

}
}

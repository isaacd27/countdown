
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public float xDistance = -1;
    public float yDistance;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        //alternative
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        /*  if (Input.GetKey(KeyCode.A))
          {
              transform.Rotate(Vector3.up, Time.deltaTime * 180);
          }
          if (Input.GetKey(KeyCode.D))
          {
              transform.Rotate(Vector3.up, Time.deltaTime * -180);
          }*/

        transform.position = player.transform.position + transform.forward * xDistance;
        transform.Translate(Vector3.up * yDistance);
    }
}


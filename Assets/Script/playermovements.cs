using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playermovements : MonoBehaviour
{
    PhotonView view;
    [SerializeField] public float timeToStop = 0.5f;
    [SerializeField] public float speedIncreasePerPress = 1.0f;
    [SerializeField] public float maxSpeed = 2000.0f;

    [SerializeField] float lastpresstime = 0.0f;
    [SerializeField] float curspeed = 0.0f;
    [SerializeField] float stopTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }


    // Update is called once per frame
    void Update()
    {
       if(view.IsMine)
        {
           // if (Input.GetKey(KeyCode.W))
          //      transform.Translate(0, 1*Time.deltaTime, 0);
          //  if (Input.GetKey(KeyCode.S))
          //      transform.Translate(0, -1 * Time.deltaTime, 0);
          //  if (Input.GetKey(KeyCode.A))
          //      transform.Translate(-1 * Time.deltaTime, 0, 0);
          //  if (Input.GetKey(KeyCode.D))
           //     transform.Translate(1 * Time.deltaTime, 0, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                curspeed += speedIncreasePerPress;
                curspeed = Mathf.Clamp(curspeed, 0.0f, maxSpeed);
                lastpresstime = 0.0f;
                stopTimer = timeToStop; // reset the timer when a button is pressed
            }
            lastpresstime += UnityEngine.Time.deltaTime;
            stopTimer -= UnityEngine.Time.deltaTime;
            if (stopTimer <= 0.0f)
            {
                curspeed = 0.0f; // stop moving if time is up
            }
            transform.Translate(1 * curspeed * Time.deltaTime, 0, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playermovements : MonoBehaviour
{
    PhotonView view;
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
            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, 1*Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, -1 * Time.deltaTime, 0);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(-1 * Time.deltaTime, 0, 0);
            if (Input.GetKey(KeyCode.D))
                transform.Translate(1 * Time.deltaTime, 0, 0);
        }
    }
}

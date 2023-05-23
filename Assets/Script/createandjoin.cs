using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class createandjoin : MonoBehaviourPunCallbacks
{
    public void create()
    {
        PhotonNetwork.CreateRoom("tutorial");
    }

    public void join()
    {
        PhotonNetwork.JoinRoom("tutorial");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("game");
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private void Start()
    {
        PhotonNetwork.Instantiate(player.name, new Vector2(Random.Range(-7.1f, 7.1f), Random.Range(3.14f, -3.14f)), Quaternion.identity);
    }

}

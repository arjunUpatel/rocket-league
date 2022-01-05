using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using System.IO;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;

public class MyPhotonPlayer : MonoBehaviourPun
{
    public GameObject myPlayer;
    Player[] allPlayers;
    int myNumberInRoom = 0;

    void Start()
    {

        allPlayers = PhotonNetwork.PlayerList;
        
        foreach (Player p in allPlayers)
        {
            if (p != PhotonNetwork.LocalPlayer)
            {
                myNumberInRoom++;
            }
        }

        Debug.Log("My number: " + myNumberInRoom);

        if (photonView.IsMine)
        {
            myPlayer = PhotonNetwork.Instantiate(gameObject.name, GameController.instance.spawnPoints[myNumberInRoom].position, GameController.instance.spawnPoints[myNumberInRoom].rotation);
            myPlayer.GetComponentInChildren<Boost>().boostText = GameObject.Find("Boost Text").GetComponent<TextMeshProUGUI>();
            myPlayer.GetComponentInChildren<Boost>().boostBar = GameObject.Find("Boost Bar Overlay").GetComponent<Image>();
        }
    }
}

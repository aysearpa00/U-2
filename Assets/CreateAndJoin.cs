using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public TMP_InputField inputCreate;
    public TMP_InputField inputJoin;
    public TMP_InputField inputNickname;


    public void CreateRoom()
    {
        PhotonNetwork.JoinOrCreateRoom(inputCreate.text,null,null);

    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(inputJoin.text);
        Debug.Log($"{inputJoin.text} adlı odaya katıldın.");
    }

    public void JoinRoomInList(string joinname)
    {
        PhotonNetwork.JoinRoom(joinname);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        PhotonNetwork.LoadLevel("SampleScene");
        PhotonNetwork.LocalPlayer.NickName = inputNickname.text;



    }
}

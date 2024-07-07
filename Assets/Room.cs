using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Room : MonoBehaviour
{
    public TMP_Text Name;
   

    public void JoinRoom()
    {
        Debug.Log(Name.text);
        GameObject.Find("CreatePanel").GetComponent<CreateAndJoin>().JoinRoomInList(Name.text);
        
    }
}

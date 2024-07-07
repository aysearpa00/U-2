using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class SpawnedObject : MonoBehaviour
{

    
    private void Start()
    {
      
        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(0f,2f,0f), Quaternion.identity);

        
        

    }
 


}

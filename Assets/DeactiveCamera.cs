using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class DeactiveCamera : MonoBehaviour
{
    private PhotonView _photon;
   
    void Start()
    {
        _photon.GetComponent<PhotonView>();
        if (!_photon.IsMine)
        {
            GetComponent<Camera>().gameObject.SetActive(false);
        }
        else
        {
            GetComponent<Camera>().gameObject.SetActive(true);
        }
        
    }


}

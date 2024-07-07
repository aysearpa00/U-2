using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class PlayerStrike : MonoBehaviour
{
   private int health=100;
   
 
   private PhotonView _photon;
   
   public TMP_Text _healthText;
   public TMP_Text _nickname;
     
   
  
   
    void Start()
    {
        _photon = GetComponent<PhotonView>();

        _healthText.text = $"Can:{health.ToString()}";
        Player _photonPlayer = _photon.Owner;
        string nickname = _photonPlayer.NickName;
        _nickname.text = nickname;
;














    }

    
    void Update()
    {
        
        if (_photon.IsMine)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastIslem();
            }
            
        }
        
    }

    void RaycastIslem()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward,out hit, 100))
        {
            hit.collider.gameObject.GetComponent<PhotonView>().RPC("vurulanNesne",RpcTarget.All,20);
        }
        
    }

    [PunRPC]
    void vurulanNesne(int deger)
    {

            health -= deger;
            _healthText.text = $"Can:{health.ToString()}";
            if (health < 40)
            {
                PhotonNetwork.Destroy(gameObject);
            }
        
        

    }
}

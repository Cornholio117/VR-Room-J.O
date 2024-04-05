﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour
{
    public GameObject Player;
    public GameObject Obs;

    void FixedUpdate()
    {    
        Quaternion lookOnLook =Quaternion.LookRotation(Player.transform.position - transform.position);
        transform.rotation =Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }
}
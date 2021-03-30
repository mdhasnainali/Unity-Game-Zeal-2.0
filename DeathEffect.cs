﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{

    void Update()
    {
        Invoke("EnemyDeathEffect",1.0f);
    }


    public void EnemyDeathEffect()
    {
        
        Destroy(this.gameObject);
        //Debug.Log("Destroy");
    }
}

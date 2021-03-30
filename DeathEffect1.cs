using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect1 : MonoBehaviour
{
    void Update()
    {
        Invoke("EnemyDeathEffect", 0.5f);
    }


    public void EnemyDeathEffect()
    {

        Destroy(this.gameObject);
        //Debug.Log("Destroy");
    }
}

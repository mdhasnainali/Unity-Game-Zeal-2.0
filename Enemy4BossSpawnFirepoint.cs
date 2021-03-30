using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4BossSpawnFirepoint : MonoBehaviour
{
    float firetime = 0.0f;
    public GameObject Poison;
    

    void Update()
    {
        
            firetime -= Time.fixedDeltaTime;
            if (firetime <= 0.0)
            {
                firetime = 5.0f;
                Instantiate(Poison, transform.position, Quaternion.identity);
                // Debug.Log("Poison");
            }
        
    }
}

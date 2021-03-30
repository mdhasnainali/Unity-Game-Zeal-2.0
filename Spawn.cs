using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    float SpawnTimer =3.0f;
    public Transform PlayerPos;
    public BossHEalth BossHealth;

    public GameObject Enemy4;
    // Update is called once per frame
    void Update()
    {
        if(PlayerPos.position.x>=1806.0&& BossHealth.BossDead==false)
        {
            SpawnTimer -= Time.deltaTime;
            if(SpawnTimer<=0)
            {
                SpawnTimer = 3.0f;
                Instantiate(Enemy4, transform.position, Quaternion.identity);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHEalth : MonoBehaviour
{
    public float Bosshealth = 1000.0f;

   public bool BossDead = false;

    public GameObject Deatheffect;
    
    public GameObject BossHealthBarPrefab0;
    public GameObject BossHealthBarPrefab1;
    public GameObject BossHealthBarPrefab2;
    public GameObject BossHealthBarPrefab3;
    public GameObject BossHealthBarPrefab4;
    public GameObject BossHealthBarPrefab5;
    public GameObject BossHealthBarPrefab6;
    public GameObject BossHealthBarPrefab7;
    public GameObject BossHealthBarPrefab8;
    public GameObject BossHealthBarPrefab9;
    public GameObject BossHealthBarPrefab10;

    public Transform BossHealthBarPosition;

    public EnemyBoss EnemyBoss;

    // Update is called once per frame
    void Update()
    {
        if (Bosshealth <0.0f) { Instantiate(BossHealthBarPrefab0, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 0.0f && Bosshealth <= 100.0f) { Instantiate(BossHealthBarPrefab1, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 100.0f && Bosshealth <= 200.0f) { Instantiate(BossHealthBarPrefab2, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 200.0f && Bosshealth <= 300.0f) { Instantiate(BossHealthBarPrefab3, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 300.0f && Bosshealth <= 400.0f) { Instantiate(BossHealthBarPrefab4, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 400.0f && Bosshealth <= 500.0f) { Instantiate(BossHealthBarPrefab5, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 500.0f && Bosshealth <= 600.0f) { Instantiate(BossHealthBarPrefab6, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 600.0f && Bosshealth <= 700.0f) { Instantiate(BossHealthBarPrefab7, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 700.0f && Bosshealth <= 800.0f) { Instantiate(BossHealthBarPrefab8, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 800.0f && Bosshealth <= 900.0f) { Instantiate(BossHealthBarPrefab9, BossHealthBarPosition.position, Quaternion.identity); }
        if (Bosshealth > 900.0f && Bosshealth <= 1000.0f) { Instantiate(BossHealthBarPrefab10, BossHealthBarPosition.position, Quaternion.identity); }

        if (Bosshealth <= 0) BossDead = true;
        if (BossDead)
        {
            BossIsDead();
            EnemyBoss.BossIsDead();
        }
    }

    public void BossIsDead()
    {
        Destroy(this.gameObject);
        
        
    }


    

    
}

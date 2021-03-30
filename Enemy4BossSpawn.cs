using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4BossSpawn : MonoBehaviour
{
    

    
    float enemy4speed = -7.0f;

    public Rigidbody2D enemy4rb;
    
    public GameObject Deatheffect;

    
    void Update()
    {
        
        
            enemy4rb.velocity = new Vector2(enemy4speed, 0f);

        
    }

    public void die()
    {
        Destroy(this.gameObject);
        Instantiate(Deatheffect, transform.position, Quaternion.identity);
    }
}

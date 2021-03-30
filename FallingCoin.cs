using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoin : MonoBehaviour
{
    public Transform player;
     float speed = -4.0f;
    public Rigidbody2D Coinrb;
    void Update()
    {
        if (player.position.x >= 1450.0f) { Coinrb.velocity = new Vector2(0.0f, speed); }
    }
    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        
            Destroy(this.gameObject);
        

      
    }
}

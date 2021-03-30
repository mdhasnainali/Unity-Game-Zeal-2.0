using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : MonoBehaviour
{
    float speed = 300f;
    bool faceleft = true;
    bool shooton = false;
    public Transform EnemyBossTransform;
    public Transform PlayerTransform;
    public Rigidbody2D EnemyBossrb;
    public Health player;

    public GameObject Deatheffect;

    public BossHEalth Bosshealth;

    public Animator animator;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerTransform.position.x < EnemyBossTransform.position.x && faceleft == false && shooton == false)
        {
            faceleft = true;
            transform.Rotate(0f, 180f, 0f);
        }
        if (PlayerTransform.position.x > EnemyBossTransform.position.x && faceleft == true && shooton == false)
        {
            faceleft = false;
            transform.Rotate(0f, 180f, 0f);
        }
        if (PlayerTransform.position.x >= EnemyBossTransform.position.x - 5f && PlayerTransform.position.x <= EnemyBossTransform.position.x + 5f && shooton == false)
        {
            shooton = true;
            Invoke("ShootOff", 1.5f);
            Invoke("HealthDecrease", 1.0f);
        }
        if (shooton)
        {
            EnemyBossrb.velocity = new Vector2(0f, 0f);
        }
        else if (faceleft && PlayerTransform.position.x >= 1806.0f) { EnemyBossrb.velocity = new Vector2(-speed * Time.deltaTime, 0f); }
        else if (faceleft == false && PlayerTransform.position.x >= 1806.0f) { EnemyBossrb.velocity = new Vector2(speed * Time.deltaTime, 0f); }
        else { EnemyBossrb.velocity = new Vector2(0f, 0f); }

        animator.SetBool("Shoot", shooton);
    }



    void ShootOff()
    {
        shooton = false;

    }

    void HealthDecrease()
    {
        if (PlayerTransform.position.y < -1.0f && PlayerTransform.position.x >= EnemyBossTransform.position.x - 5.0f && PlayerTransform.position.x <= EnemyBossTransform.position.x && faceleft)
        {
            player.health--;
        }
        if (PlayerTransform.position.y < -1.0f && PlayerTransform.position.x >= EnemyBossTransform.position.x  && PlayerTransform.position.x <= EnemyBossTransform.position.x +5f && !faceleft)
        {
            player.health--;
        }
    }

    public void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        //Debug.Log(collisioninfo.collider.name);
        Debug.Log(collisioninfo.collider.tag);
        if (collisioninfo.collider.tag == "Bullet")
        {

            

            Debug.Log(collisioninfo.collider.tag);
            
        }

    }
    public void Hit(Transform hittransform)
    {
        Bosshealth.Bosshealth -= Time.deltaTime * 500.0f;

        Debug.Log(Bosshealth);
        Instantiate(Deatheffect, hittransform.position, Quaternion.identity);
    }
    public void BossIsDead()
    {
        Destroy(this.gameObject);

        Instantiate(Deatheffect, transform.position, Quaternion.identity);
    }
}

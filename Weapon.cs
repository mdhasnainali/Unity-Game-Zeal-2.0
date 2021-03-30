﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject BulletPrefab;
    public GameObject BoomerangPrefab;

    public AudioSource FireSound;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ShootBullet();

            FireSound.Play();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ShootBoomerang();
            FireSound.Play();
        }

    }
    
    public void ShootBullet()
    {
        Instantiate(BulletPrefab, firepoint.position, firepoint.rotation);
    }
    public void ShootBoomerang()
    {
        Instantiate(BoomerangPrefab, firepoint.position, firepoint.rotation);
    }
}

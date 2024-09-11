using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float chargeSpeed = 10f;
    private float chargeTime = 0f;
    public float baseBulletSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetButtonDown("Fire1"))
            {
                this.chargeTime = 0;
            }

            if (Input.GetButton("Fire1") && chargeTime < 3)
            {
                this.chargeTime += Time.deltaTime;
            }

            if (Input.GetButtonUp("Fire1"))
            {
               
                // Spawn bullet when Fire1 is released
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                BulletComponent bulletComp = bullet.GetComponent<BulletComponent>();
                bulletComp.bulletSpeed = chargeTime * baseBulletSpeed;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public Transform firePoint;
    public float fireRate = 1.5f;

    float nextFireTime;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        Instantiate(
            enemyBulletPrefab,
            firePoint.position,
            Quaternion.identity
        );
    }
}

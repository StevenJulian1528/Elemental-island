using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 50;
    public Transform firePoint;
    public GameObject projectilePrefab;
    public float timerShoot = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerShoot -= Time.deltaTime;
        if (timerShoot <= 0f)
        {
            shoot();
            timerShoot = 2f;
        }
    }
    void shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}

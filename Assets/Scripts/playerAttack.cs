using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public Animator anim;
    public Transform firePoint;
    public GameObject bulletPrefabRight, bulletPrefabLeft;
    public static GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        anim.SetTrigger("isShot");
        Vector3 characterScale = player.transform.localScale;

        if (characterScale.x == 1)
        {
            Instantiate(bulletPrefabRight, firePoint.position, firePoint.rotation);
        }
        if (characterScale.x == -1)
        {
            Instantiate(bulletPrefabLeft, firePoint.position, firePoint.rotation);
        }
    }
}

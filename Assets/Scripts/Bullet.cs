using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet, impactEffect;
    public float speed = 20f;
    public int damage = 50;
    public Rigidbody2D rb;
    public static GameObject player;
    public float timerShoot = 3f;
    public AudioSource shot,kena;

    // Start is called before the first frame update
    void Start()
    {
        shot.Play();
        player = GameObject.Find("Player");

        Vector3 characterScale = player.transform.localScale;
        Vector3 bulletScale = bullet.transform.localScale;
        if (characterScale.x == 1)
        {
            rb.velocity = transform.right * speed;
            bulletScale.x = 1;
        }
        else if (characterScale.x == -1)
        {
            print("-1");
            rb.velocity = -transform.right * speed;
            bulletScale.x = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timerShoot -= Time.deltaTime;
        if (timerShoot <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        Enemy enemy = hit.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.takeDamage(damage);
        }
        //Instantiate(impactEffect, transform.position, transform.rotation);
        if(hit.gameObject.tag.Equals("Enemy"))
        Destroy(gameObject);

        EnemyBabi enemybabi = hit.GetComponent<EnemyBabi>();
        if (enemybabi != null)
        {
            enemybabi.takeDamage(damage);
        }
        //Instantiate(impactEffect, transform.position, transform.rotation);
        if (hit.gameObject.tag.Equals("Enemy"))
            Destroy(gameObject);

        EnemyBoss enemyboss = hit.GetComponent<EnemyBoss>();
        if (enemyboss != null)
        {
            enemyboss.takeDamage(damage);
        }
        //Instantiate(impactEffect, transform.position, transform.rotation);
        if (hit.gameObject.tag.Equals("Enemy"))
            Destroy(gameObject);

        if (hit.gameObject)
        {
            kena.Play();
            Destroy(gameObject);
        }
    }
}

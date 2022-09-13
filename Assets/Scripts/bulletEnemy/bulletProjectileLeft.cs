using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletProjectileLeft : MonoBehaviour
{
    public AudioSource shot;
    public bool isRight;
    public float speed = 20f;
    public Rigidbody2D rb;
    public float timerShoot = 2f;
    // Start is called before the first frame update
    void Start()
    {
        shot.Play();
        rb.velocity = -transform.right * speed;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBabi : MonoBehaviour
{
    public int health = 100;
    Animator anim;
    public AudioSource ded;
    Collider cd;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ded.Play();
        if(gameObject.transform.eulerAngles.z == 180)
        {
            print("");
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        //transform.position = Vector3.zero;
        anim.SetBool("isBabiDie", true);
    }

}

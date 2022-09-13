using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossAttack : MonoBehaviour
{
    public GameObject bulletBossPrefab;
    public Transform[] firepoint;
    public Transform pos1, pos2,pos3,pos4;
    public float speed,speedWalk;
    public Transform startPos;
    float timerRush = 10f;
    public AudioSource attack, shot;
    bool rush;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("bossShot", 1f, 4f);
        InvokeRepeating("bossShot", 1.5f, 4f);
        InvokeRepeating("bossShot", 2f, 4f);
        InvokeRepeating("bossShot", 2.5f, 4f);
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        timerRush -= Time.deltaTime;
        if(timerRush <= 0)
        {
            timerRush = 10f;
            rush = true;
        }

        walk();
        bossRush();
        print(timerRush);
    }
    void bossRush()
    {
        if (rush)
        {
            if (transform.position == pos1.position)
            {
                attack.Play();
                nextPos = pos2.position;
                transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
            }
            if (transform.position == pos2.position)
            {
                nextPos = pos1.position;
                transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
                rush = false;
            }
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        }
    }

    void bossShot()
    {
        shot.Play();
        int i = Random.Range(0, 5);
        Instantiate(bulletBossPrefab, firepoint[i].position, firepoint[i].rotation);
    
    }
    void walk()
    {
        if (transform.position == pos3.position)
        {
            nextPos = pos4.position;
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speedWalk * Time.deltaTime);
        }
        if (transform.position == pos3.position)
        {
            nextPos = pos4.position;
            transform.position = Vector3.MoveTowards(transform.position, nextPos, speedWalk * Time.deltaTime);
            rush = false;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speedWalk * Time.deltaTime);
    }

}

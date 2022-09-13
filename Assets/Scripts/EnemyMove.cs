using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    public static bool enemyAlive = true;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {
        if(enemyAlive)
        {
            //Vector3 charecterScale = transform.localScale;
            //if (transform.position == pos1.position)
            //{
            //    charecterScale.x = 1;
            //    nextPos = pos2.position;

            //}
            //if (transform.position == pos2.position)
            //{
            //    charecterScale.x = -1;
            //    nextPos = pos1.position;
            //}
            //transform.localScale = charecterScale;
            //transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
            enemyPatrol();
        }


    }

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawLine(pos1.position, pos2.position);
    //}
    private void enemyPatrol()
    {
        Vector3 charecterScale = transform.localScale;
        if (transform.position == pos1.position)
        {
            charecterScale.x = 1;
            nextPos = pos2.position;

        }
        if (transform.position == pos2.position)
        {
            charecterScale.x = -1;
            nextPos = pos1.position;
        }
        transform.localScale = charecterScale;
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallSpike : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D boxCollider2D;
    public float distance;
    bool isFalling = false;
    playerController playerController;
    public AudioSource fall;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        if (isFalling == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.right, distance, 1 << 8);
            Debug.DrawRay(transform.position, Vector2.right * distance, Color.red);

            if (hit.transform.tag.Equals("Player"))
            {
                fall.Play();
                rb.gravityScale = 5;
                isFalling = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag.Equals("Ground")))
        {
            boxCollider2D.enabled = false;
        }
    }
}
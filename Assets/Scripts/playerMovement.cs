using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Move and Jump")]
    public float speed;
    bool isWalking;

    [Header("Jump")]
    public float jumpAccel;
    public float jumpForce;
    private bool isOnGround;

    [Header("Ground Raycast")]
    public LayerMask groundLayerMask;

    [Header("Animator")]
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        // Debug.Log(rb.velocity.y);

        Vector3 charecterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            charecterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            charecterScale.x = 1;
        }
        transform.localScale = charecterScale;
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            anim.SetBool("isWalk", true);
            Move();
        }
        else
        {
            anim.SetBool("isWalk", false);
        }


        if (rb.velocity.y == 0)
        {
            isOnGround = true;
        }


        else
        {
            isOnGround = false;
        }
    }

    public void Move()
    {
        isWalking = true;
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);

    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
            rb.AddForce(Vector2.up * jumpForce);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("FlyGround"))
        {
            this.transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("FlyGround"))
        {
            this.transform.parent = null;
        }
    }
}



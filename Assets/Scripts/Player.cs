using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    CapsuleCollider2D myCollider;
    public GameObject bullet;
    int numbullet = 10;
    //public  GameObject pos;

    [SerializeField] float jumpheight = 7f;
    [SerializeField] float movespeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        myCollider = GetComponent<CapsuleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            anim.SetBool("isRunning", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            anim.SetBool("isRunning", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (myCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                rb.AddForce(Vector2.up * jumpheight, ForceMode2D.Impulse);
            }

        }

        if (Input.GetKeyDown(KeyCode.Z))
        {

            Instantiate(bullet, transform.position + new Vector3(transform.localScale.x * 1.2f, 0, 0), transform.rotation);


        }
    }

}
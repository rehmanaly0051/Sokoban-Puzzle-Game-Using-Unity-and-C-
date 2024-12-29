using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 6f;
    CircleCollider2D myCollider;
    Player playerScale;
    float sign;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<CircleCollider2D>();
        playerScale = FindObjectOfType<Player>();
        sign = playerScale.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.Translate(sign * speed * Time.deltaTime,0,0);

     

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
     
        Destroy(gameObject);
   
    }
}

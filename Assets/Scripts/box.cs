using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    BoxCollider2D myCollider;
    SpriteRenderer sr;
    GameManager gm;

    public Sprite Blue_Box;
    public Sprite Brown_Box;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        sr = GetComponent<SpriteRenderer>();
        myCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        sr.sprite = Brown_Box;
        gm.removeScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        sr.sprite = Blue_Box;
        gm.AddScore();
    }
}

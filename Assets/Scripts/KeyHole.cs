using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyHole : MonoBehaviour
{
    Key key;
    // Start is called before the first frame update
    void Start()
    {
        key = FindObjectOfType<Key>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Player") && key.hasKey)
        {
            Debug.Log("Has key and collision with door , level completed");
            SceneManager.LoadScene(1);

        }
    }
}

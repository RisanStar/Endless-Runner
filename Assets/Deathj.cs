using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deathj : MonoBehaviour
{ 
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            die();
        }
    }
     private void die()
        {
            rb.bodyType = RigidbodyType2D.Static;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
 
}

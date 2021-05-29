using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb2;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2.velocity = Vector2.up * this.velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("we are in the OnCollaiderEnter2D");
        gameManager.GameOver();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Text rupiasText;

    public Rigidbody2D rigidBody2D;
    public float speed = 100f;

    private float direction;

    int rupias = 0;

    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rupia"))
        {
            rupias++;

            rupiasText.text = "RUPIAS: " + rupias.ToString();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            rupias -= 2;
            if (rupias < 0)
            {
                rupias = 0;
            }

            rupiasText.text ="RUPIAS: " + rupias.ToString();

        }
    }
}

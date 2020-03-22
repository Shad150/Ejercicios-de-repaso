using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed = 0.5f;

    void Start()
    {
        Invoke("Destroyer", 6);
    }

    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * Vector3.down;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroyer();
        }
    }

    void Destroyer()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float speed;

    public float maxJump = 2;

    private float timer;
    public float shieldTime = 2;

    public GameObject theShield;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        shieldDo();
    }

    void shieldDo()
    {
        if(timer > shieldTime)
        {
            GameObject newShield = Instantiate(theShield);
            newShield.transform.position = transform.position + new Vector3(Random.Range(1,2), 0, 0);
            Destroy(newShield, 6);
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -12.2)
        {
            transform.position = new Vector3(12.2f, transform.position.y, 0f);
        }

        if (transform.position.y <= 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxJump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

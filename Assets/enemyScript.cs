using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float speed;


    private float timer;
    public float maxTime = 2;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        
        if (transform.position.x <= -12.2f)
        {
            transform.position = new Vector3(12.2f, transform.position.y, 0f);
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

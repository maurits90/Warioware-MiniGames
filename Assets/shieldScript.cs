using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour
{

    public float speed;

    public float maxJump = 2;

    private float timer;
    public float maxTimeStop = 1;

    Rigidbody2D rb;
    // Start is called before the first frame update
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
        if (transform.position.x <= -12.2)
        {
            transform.position = new Vector3(12.2f, transform.position.y, 0f);
        }
    }
}

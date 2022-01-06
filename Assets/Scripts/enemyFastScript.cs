using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFastScript : MonoBehaviour
{
    Rigidbody2D rb;
    float time;
    float randomHeight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.left * 13 * Time.deltaTime;
        rb.velocity = new Vector2(12, rb.velocity.y);
        offField();
    }

    void offField()
    {
        if (time < 0)
        {
            randomHeight = Random.Range(8f, 16f);
            time = 2;
        }
        time -= Time.deltaTime;

        if (transform.position.x >= 12)
        {
            transform.position = new Vector3(-12f, randomHeight, 0);
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{
    public float speed;

    public Text asd;

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
        asd.text = "" + timer.ToString("F0");
        Move();
    }


    void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x <= -12.2f)
        {
            transform.position = new Vector3(12.2f, transform.position.y, 0f);
        }
        if(timer > maxTime)
        {
            
            timer = 0;
        }
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        } 
        if (timer <= 1f)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}

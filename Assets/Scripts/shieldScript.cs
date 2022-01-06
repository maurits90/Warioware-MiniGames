using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldScript : MonoBehaviour
{

    private float timer;
    public float maxTime = 4;

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
        if (timer > maxTime)
        {
            timer = 0;
        }
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            transform.localPosition = new Vector3(-2f, 0f, 0f); 
        }
        if (timer <= 1)
        {
            transform.localPosition = new Vector3(2f, 0f, 0f);
        }

    }
}

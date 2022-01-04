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

    public Transform pos1,pos2;
    public Transform startPos;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        asd.text = "" + timer.ToString("F0");
        Move();
        UpAndDown();
    }


    void UpAndDown()
    {
        if (timer > maxTime)
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

    void Move()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }


}

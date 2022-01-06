using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour
{
    public float speed;

    private float timer;
    public float maxTime = 2;

    public Transform pos1,pos2,pos3,pos4,pos5,pos6,pos7;
    public Transform startPos;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos3.position;
        }
        if (transform.position == pos3.position)
        {
            nextPos = pos4.position;
        }
        if (transform.position == pos4.position)
        {
            nextPos = pos5.position;
        }
        if (transform.position == pos5.position)
        {
            nextPos = pos6.position;
        }
        if (transform.position == pos6.position)
        {
            nextPos = pos7.position;
        }
        if (transform.position == pos7.position)
        {
            nextPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
        Gizmos.DrawLine(pos2.position, pos3.position);
        Gizmos.DrawLine(pos3.position, pos4.position);
        Gizmos.DrawLine(pos4.position, pos5.position);
        Gizmos.DrawLine(pos5.position, pos6.position);
        Gizmos.DrawLine(pos6.position, pos7.position);
        Gizmos.DrawLine(pos7.position, pos1.position);
    }


}

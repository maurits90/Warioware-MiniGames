using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform pos1;
    public Transform startPos;
    Vector3 nextPos;
    public float speed;

    public GameObject enmy1, enmy2;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCheck();
    }

    void enemyCheck()
    {
        if(enmy1 == null && enmy2 == null)
        {
            doMove();
        }
    }

    void doMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}

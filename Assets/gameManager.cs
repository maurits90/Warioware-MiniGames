using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public float time;

    public Text timeTxt;

    public GameObject gameOverCanvas;
    public GameObject gameWonCanvas;

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false);
        gameWonCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeTxt.text = "" + time.ToString("F0");
        if(time < 0)
        {
            Time.timeScale = 0;
            gameOverCanvas.SetActive(true);
        }
        if(enemy == null)
        {
            // next level
            gameWonCanvas.SetActive(true);
            time = time;
            Time.timeScale = 0;
        }
        time -= Time.deltaTime;
    }
}

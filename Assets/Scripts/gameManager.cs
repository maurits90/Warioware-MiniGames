using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public float time;

    public Text timeTxt;

    public GameObject gameOverCanvas;
    public GameObject gameWonCanvas;

    public audioScript sound;

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
            playSound();
            gameWonCanvas.SetActive(true);
            time = 1;
            Time.timeScale = 0;
        }
        time -= Time.deltaTime;

    }
    void playSound()
    {
        sound.playGameWon();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        sound.playSFX1();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public AudioSource jump;
    public AudioSource gameOver;
    public AudioSource gameWon;
    public AudioSource hitEnemy;
    public AudioSource sfx1;

    public void playJump()
    {
        jump.Play();
    }
    public void playGameOver()
    {
        gameOver.Play();
    }
    public void playGameWon()
    {
        gameWon.Play();
    }
    public void playHitEnemy()
    {
        hitEnemy.Play();
    }

    public void playSFX1()
    {
        sfx1.Play();
    }
}

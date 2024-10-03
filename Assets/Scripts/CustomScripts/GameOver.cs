using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Game Management Script - handles user input once game is over.
 * Contains functions to restart and quit the game when corresponding button called.
 */
public class GameOver : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

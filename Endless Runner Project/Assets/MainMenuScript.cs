using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public LevelLoader other;

    public void PlayTheGame()
    {
        other.LoadGame();
    }

    public void QuitTheGame()
    {
        Debug.Log("QUIT THE GAME");
        Application.Quit();
    }
}

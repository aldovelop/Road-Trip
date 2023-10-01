using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public LevelLoader other;

    public void Retry()
    {
        other.LoadGame();
        ScoreScript.scoreValue = 0;
    }

    public void Exit()
    {
        other.LoadMenu();
        ScoreScript.scoreValue = 0;
        Collector.best = 0;
    }
}


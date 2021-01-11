using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Accelerator AC;
    public Animator floorAnimator;

    private void Start()
    {
        AC = GetComponent<Accelerator>();
    }
    private void Update()
    {
        floorAnimator.speed = AC.speed;
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Statics.score = GetComponent<ScoreTracker>().score;
        GetComponent<SceneController>().LoadNextScene();
    }
}

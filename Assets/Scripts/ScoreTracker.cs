using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;

    public float score;
    public float passiveScoreGain = 1f;

    void Update()
    {
        score += passiveScoreGain * Time.deltaTime;
        scoreDisplay.text = "Score: " + Mathf.RoundToInt(score).ToString();
    }
    public void AddToScore(float num)
    {
        score += num;
    }
    public void HalfScore()
    {
        score = score / 2f;
    }
}

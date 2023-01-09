using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
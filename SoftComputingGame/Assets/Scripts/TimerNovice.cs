using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerNovice : MonoBehaviour
{
    private float timer = 50f;
    private Text timerSeconds;
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}

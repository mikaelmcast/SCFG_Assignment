using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int GameDifficulty = 0;
    //private float timer;


    //Singleton
    protected static GameManager Instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }

        Instance = this;
        DontDestroyOnLoad(this);
    }


    public void StartGame(int difficulty)
    {
        GameDifficulty = difficulty;
        SceneManager.sceneLoaded += SceneChanged;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(difficulty);
    }


    private void SceneChanged(Scene scene, LoadSceneMode mode)
    {
        string difficulty;
        if (scene.name == "Stranded")
        {
            switch (GameDifficulty)
            {
                case 3:
                    difficulty = "Hard";
                    break;
                case 2:
                    difficulty = "Medium";
                    break;
                default:
                    difficulty = "Easy";
                    break;
            }


        }

    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneChanged;
    }

}
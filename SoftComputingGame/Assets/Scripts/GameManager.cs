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


    /*public void StartGame(int difficulty)
    {
        Debug.Log("test");
        GameDifficulty = difficulty;
        SceneManager.sceneLoaded += SceneChanged;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(difficulty);
        Cursor.visible = true;
    }*/


    /*private void SceneChanged(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(scene.name);
        string difficulty;
        if (scene.name == "GamePlay")
        {
            switch (GameDifficulty)
            {
                case 3:
                    difficulty = "Professional";
                    break;
                case 2:
                    difficulty = "Novice";
                    break;
                default:
                    difficulty = "Beginner";
                    break;
            }


        }

    }*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Beg();
        } 
        else if ((Input.GetKeyDown(KeyCode.N))) 
        {
            Nov();
        }
        else if ((Input.GetKeyDown(KeyCode.O)))
        {
            Pro();
        }
    }

    public void Beg()
    {
        SceneManager.LoadScene("Beginner");
        Debug.Log("Beginner");
    }

    public void Nov()
    {
        SceneManager.LoadScene("Novice");
        Debug.Log("Novice");
    }

    public void Pro()
    {
        SceneManager.LoadScene("Professional");
        Debug.Log("Professional");
    }

    /*private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneChanged;
    }*/

}
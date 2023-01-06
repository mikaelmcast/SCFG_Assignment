using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Play();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = true;
    }
}
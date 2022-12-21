using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BeginnerGame()
    {
        SceneManager.LoadScene(1);
    }
    public void NoviceGame()
    {
        SceneManager.LoadScene(2);
    }
    public void ProfessionalGame()
    {
        SceneManager.LoadScene(3);
    }
}

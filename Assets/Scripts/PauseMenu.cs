using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool PlayerIsDead = false;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Prototype 3");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game!");
    }
}

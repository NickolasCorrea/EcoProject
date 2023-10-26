using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject menu;
    public int difficulty;

    public void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Retry(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void SetDifficulty(int newDifficulty)
    {
        difficulty = newDifficulty;
    }

}
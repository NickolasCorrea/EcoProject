using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] GameObject menuAtual;
    [SerializeField] GameObject menuNovo;

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void OpenMenu()
    {
        menuNovo.SetActive(true);
        menuAtual.SetActive(false);
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SceneSelector(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void Awake()  // Usamos Awake(), pois ele pode prevenir bugs ao usar o metodo de FindObjectOfType()
    {

    }

    void Start() // Usamos Start() para configurar quais telas estarão ativas ou não.
    {
        //quiz.gameObject.SetActive(true); // Ativa algum gameObject
        //endScreen.gameObject.SetActive(false); // Desativa algum gameObject
    }

    void Update()
    {
        /*
        if(quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
        */
    }

    public void OnReplayLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
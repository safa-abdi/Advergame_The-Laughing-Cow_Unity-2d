using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fonctions : MonoBehaviour
{
    public void Fermer()
    {
        Application.Quit();
    }
    public void SceneAcceuil()
    {
        SceneManager.LoadScene("scene2");
    }
    public void SceneChoitNiveau()
    {
        SceneManager.LoadScene("ChoitNiv");
    }
    public void SceneJigsawPuzzle()
    {
        SceneManager.LoadScene("sc2_2");
    }
    public void ScenePuzzle()
    {
        SceneManager.LoadScene("newpuz");
    }
    public void SceneNiv2()
    {
        SceneManager.LoadScene("newpuz");
    }
    public void Scenegagné()
    {
        SceneManager.LoadScene("gagné");
    }
    public void Parametres()
    {
        SceneManager.LoadScene("parametres");
    }
    public void SceneNiveau1()
    {
        SceneManager.LoadScene("niveau1");
    }
    public void SceneInstructions()
    {
        SceneManager.LoadScene("instructions");
    }
    public void SceneApropos()
    {
        SceneManager.LoadScene("a propos");
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;

    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

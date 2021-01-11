using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject instructionsMenu;
    public GameObject mainMenu;
    public void SetInstructions()
    {
        if(instructionsMenu && mainMenu)
        {
            instructionsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
    }
    public void SetMain()
    {
        if (instructionsMenu && mainMenu)
        {
            instructionsMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    public void LoadNextScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex + 1);
    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

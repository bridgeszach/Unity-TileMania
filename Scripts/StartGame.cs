using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
  public void StartLevel()
    {
        SceneManager.LoadScene("Level 1");
    }

  
  public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls");
    }

    
    public void StartMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}

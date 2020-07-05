using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{    
    [SerializeField] int playerLives = 3;
    //[SerializeField] AudioClip coinSFX; TODO: Add background music

    // Singleton Pattern for disallowing multiple game sessions at one time.
    private void Awake()
    {
        int numGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {            
            TakeLife();
        }
        else
        {
            StartCoroutine(DeathDelay(5));
            ResetGameSession();
        }
    }

    IEnumerator DeathDelay(int time)
    {
        yield return new WaitForSeconds(time);
    }


    private void TakeLife()
    {
        playerLives--;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);

    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}


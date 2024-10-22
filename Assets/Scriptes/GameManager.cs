using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Boolean gameHasEnded = false;
    public GameObject restartScreen;
    public float restartDelay = 1f;
    public void endGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded =true;
            Debug.Log("TheEnded");
            
            Invoke("screenEnable",restartDelay);
        }

    }

    public void screenEnable()
        {
            restartScreen.SetActive(true);
        }

    public void restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
}

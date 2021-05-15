using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGameScene : MonoBehaviour
{

    public GameObject inGameScreen, pauseScreen;

    public GameObject joystick;

    public void PauseButton()  
    {
        Time.timeScale = 0;       
        inGameScreen.SetActive(false);   
        pauseScreen.SetActive(true);
        joystick.SetActive(false);
    }

    public void PlayButton()    
    {
        Time.timeScale = 1;  
        inGameScreen.SetActive(true); 
        pauseScreen.SetActive(false);
    }

    public void RePlayButton()
    {
        Time.timeScale = 1;  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    
}

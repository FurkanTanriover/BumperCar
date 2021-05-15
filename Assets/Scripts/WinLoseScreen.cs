
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinLoseScreen : MonoBehaviour
{

    public void RePlayButton()
    {
        Time.timeScale = 1;  
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)); 

    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

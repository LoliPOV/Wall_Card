using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseController : Pause
{

    public void GamePaused()
    {
        PauseGame();
    }

    public void GameUnPaused()
    {
        UnPauseGame();
    }
    
    public void RestartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}

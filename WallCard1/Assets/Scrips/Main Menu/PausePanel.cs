using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    
    [SerializeField] private Canvas _settings;
    [SerializeField] private Image _pause;
    [SerializeField] private Button _btnForPause;
    

    public void GoSettings()
    {
        _settings.gameObject.SetActive(true);
    }

    public void Pause()
    {
        _pause.gameObject.SetActive(true);
        _btnForPause.interactable = false;
        Time.timeScale = 1;
    }

    public void Back()
    {
        _pause.gameObject.SetActive(false);
        _btnForPause.interactable = true;
        Time.timeScale = 0;
    }

    public void GoMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }



    
}

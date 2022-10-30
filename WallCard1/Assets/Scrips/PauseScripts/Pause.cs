using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject _pausePanel;

    public void PauseGame()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void UnPauseGame()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}

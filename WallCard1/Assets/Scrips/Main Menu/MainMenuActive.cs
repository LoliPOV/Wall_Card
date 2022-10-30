using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuActive : MonoBehaviour
{
    [SerializeField] private Canvas _mainMenu;
  
    private void Awake()
    {
        _mainMenu.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        MoveWall.Speed = -3.5F;
        SceneManager.LoadSceneAsync(2);
    }

    public void GoToShop()
    {
        SceneManager.LoadSceneAsync(1);
    }
}

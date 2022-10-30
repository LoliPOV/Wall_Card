using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    private string _purchasedBackground;
    public int _isPurchased;
    public Button[] buttons;
    public void BuyBackGroundOne()
    {
        if (CoinS.totalcoins >= 100)
        {
            _purchasedBackground = "Prefabs/BackGroundPrefabs/Background";
            PlayerPrefs.SetString("SavedStringBackgroundOne", _purchasedBackground);
            _isPurchased = 1;
            CoinS.totalcoins -= 100;
            buttons[0].interactable = false;
            PlayerPrefs.SetInt("IsPurchased1", _isPurchased);
            PlayerPrefs.Save();
        }
    }
    public void BuyBackGroundTwo()
    {
        if (CoinS.totalcoins >= 300)
        {
            _purchasedBackground = "Prefabs/BackGroundPrefabs/Background 1";
            PlayerPrefs.SetString("SavedStringBackgroundTwo", _purchasedBackground);
            _isPurchased = 1;
            CoinS.totalcoins -= 300;
            buttons[1].interactable = false;
            PlayerPrefs.SetInt("IsPurchased2", _isPurchased);
            PlayerPrefs.Save();
        }
    }
    public void BuyBackGroundThre()
    {
        if (CoinS.totalcoins >= 100)
        {
            _purchasedBackground = "Prefabs/BackGroundPrefabs/Background 2";
            PlayerPrefs.SetString("SavedStringBackgroundThre", _purchasedBackground);
            _isPurchased = 1;
            CoinS.totalcoins -= 100;
            buttons[2].interactable = false;
            PlayerPrefs.SetInt("IsPurchased3", _isPurchased);
            PlayerPrefs.Save();
        }
    }
    public void BuyBackGroundFore()
    {
        if (CoinS.totalcoins >= 200)
        {
            _purchasedBackground = "Prefabs/BackGroundPrefabs/Background 3";
            PlayerPrefs.SetString("SavedStringBackgroundFore", _purchasedBackground);
            _isPurchased = 1;
            CoinS.totalcoins -= 200;
            buttons[3].interactable = false;
            PlayerPrefs.SetInt("IsPurchased4", _isPurchased);
            PlayerPrefs.Save();
        }
        
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        SetBackGround._isSet = false;
        Debug.Log("Data reset complete");
    }

    public void GoToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}



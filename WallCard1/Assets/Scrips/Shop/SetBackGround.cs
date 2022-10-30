using UnityEngine;

public class SetBackGround : MonoBehaviour
{
    public static GameObject _background;
    private string _purchasedBackground;
    public static bool _isSet = false;
    
    public void SetBackGroundOne()
    {
        if (PlayerPrefs.HasKey("IsPurchased1"))
        {
            _purchasedBackground = PlayerPrefs.GetString("SavedStringBackgroundOne", _purchasedBackground);
            _isSet = true;
            _background = Resources.Load<GameObject>(_purchasedBackground);            
        }       
    }
    public void SetBackGroundTwo()
    {
        if (PlayerPrefs.HasKey("IsPurchased2"))
        {
            _purchasedBackground = PlayerPrefs.GetString("SavedStringBackgroundTwo", _purchasedBackground);
            _isSet = true;
            _background = Resources.Load<GameObject>(_purchasedBackground);
        }
    }
    public void SetBackGroundThre()
    {
        if (PlayerPrefs.HasKey("IsPurchased3"))
        {
            _purchasedBackground = PlayerPrefs.GetString("SavedStringBackgroundThre", _purchasedBackground);
            _isSet = true;
            _background = Resources.Load<GameObject>(_purchasedBackground);
        }
    }
    public void SetBackGroundFore()
    {
        if (PlayerPrefs.HasKey("IsPurchased4"))
        {
            _purchasedBackground = PlayerPrefs.GetString("SavedStringBackgroundFore", _purchasedBackground);
            _isSet = true;
            _background = Resources.Load<GameObject>(_purchasedBackground);
        }       
    }

}

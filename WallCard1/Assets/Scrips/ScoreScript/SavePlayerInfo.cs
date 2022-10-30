using UnityEngine;

public class SavePlayerInfo : MonoBehaviour
{
    [SerializeField] private ShowHightScore _showHightScore;

    private float _pointToSave;
    private int _coinsToSave;
    private void Awake()
    {
        _coinsToSave = CoinS.totalcoins;
        SaveInfo();
    }
    public void SaveInfo()
    {
        PlayerPrefs.SetInt("coinsToSave", _coinsToSave);
        Debug.Log(PlayerPrefs.GetInt("coinsToSave", _coinsToSave));
    }
}

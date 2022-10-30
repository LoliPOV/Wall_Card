using UnityEngine;
using TMPro;

public class CoinS : MonoBehaviour
{
    public TextMeshProUGUI _coins;
    public static int totalcoins = 300;

    void Update()
    {
        _coins.text = totalcoins.ToString();       
    }
    private void OnPlayerCoinsChanged(int total)
    {
        totalcoins += total;
        _coins.text = totalcoins.ToString();
    }
    private void OnEnable()
    {
        CheckTrue.onCoinsColected += OnPlayerCoinsChanged;
    }
    private void OnDisable()
    {
        CheckTrue.onCoinsColected -= OnPlayerCoinsChanged;
    }
}

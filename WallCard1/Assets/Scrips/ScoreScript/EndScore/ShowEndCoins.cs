using TMPro;

public class ShowEndCoins : CoinS
{
    public TextMeshProUGUI _showCoins;
    void Start()
    {
        _showCoins = GetComponent<TextMeshProUGUI>();
        _showCoins.text = totalcoins.ToString();
    }
   
}

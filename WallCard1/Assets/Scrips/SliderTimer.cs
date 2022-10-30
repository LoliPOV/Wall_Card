using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderTimer : MonoBehaviour
{
    [SerializeField] private Image _timeImage;
    [SerializeField] private float _seconds;
    [SerializeField] BuyBack buyBack;
    private int lvl = 0;

    public float TotalCoins = CoinS.totalcoins;
    public float TotalScore = SetPoints._gamePoint;


    private void Start()
    {
        TotalCoins = CoinS.totalcoins;
        TotalScore = SetPoints._gamePoint;
        _timeImage = this.gameObject.GetComponent<Image>();
    }


    private void Update()
    {
        _timeImage.fillAmount -= Time.deltaTime / _seconds;

        if (_timeImage.fillAmount <= 0.01) 
        {
            SceneManager.LoadSceneAsync(lvl);
        }

        if (buyBack._checked)
        {
            _timeImage.fillAmount = 1f;
            buyBack._checked = false;
        }
    }
}

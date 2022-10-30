using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameStatus : CoinS
{
    private int _priceFirstPalette = 100;
    [SerializeField] private Button _priceButtonOne;
    [SerializeField] private Button _colorPalleteOne;
    [SerializeField] private BuyBack _buyBack;

    private Animation anim;
    private void Start()
    {
        anim = this.GetComponent<Animation>();
    }

    public void PurchasePalette()
    {
        if (CoinS.totalcoins < _priceFirstPalette)
        {
            anim.Play();
        }
        else
        { 
            _buyBack.DoBuyBack();           
        }
    }

    public void ExitToMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
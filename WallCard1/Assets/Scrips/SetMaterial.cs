using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetMaterial : CoinS
{
    private int _priceFirstPalette = 100;
    [SerializeField] 
    private Button _priceButtonOne;
    [SerializeField]
    private GameObject _endCanvas, _gameCanvas;
    [SerializeField] 
    private Button _colorPalleteOne;

    public static bool _buyBack = false;
    bool _isClicked;

    private Animation anim;
    
    private void Start()
    {
        anim = this.GetComponent<Animation>();
    }
    public void PurchasePalette()
    {   
        _isClicked = true;    
        if (totalcoins < _priceFirstPalette)
        {
            anim.Play();
        }        
        else if (_isClicked && totalcoins >= _priceFirstPalette)
        {
            totalcoins -= _priceFirstPalette;

            LivesScript.lives = 3;

            _gameCanvas.SetActive(true);
            _endCanvas.SetActive(false);

            _buyBack = true;

            Destroy(_priceButtonOne);
            _colorPalleteOne.interactable = true;
        }
    }
}
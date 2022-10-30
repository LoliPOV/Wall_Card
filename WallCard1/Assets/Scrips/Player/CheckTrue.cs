using UnityEngine;

public class CheckTrue : MonoBehaviour
{
    private GameObject Cone, Cube, Ball;
    protected static int _steps;
    int _takeCoins = 5, _coins;

    public static event OnCoinsColected onCoinsColected;

    public delegate void OnCoinsColected(int _totalcoins);

    private void OnTriggerEnter(Collider other)
    {
        Cube = GameObject.FindWithTag("CubePlayerT");Cone = GameObject.FindWithTag("ConePlayerT"); Ball = GameObject.FindWithTag("BallPlayerT");
        bool checkTrue = Cube && GameObject.FindWithTag("CubeWallT") == true || Cone && GameObject.FindWithTag("ConeWallT") == true
        || Ball && GameObject.FindWithTag("BallWallT") == true;
       
        if (checkTrue)
        {
            int _coinwall = Random.Range(1, 999) / 15;

            SetPoints._gamePoint += 10; 
            
            if (_coinwall >= 20 && _coinwall <= 30)
            {
                _coins =_takeCoins;
                onCoinsColected?.Invoke(_coins);
            }

        }
        else { LivesScript.lives--; }
    }                
}

using UnityEngine;
using TMPro;

public class SetPoints : MonoBehaviour
{
    public static float _gamePoint;
    private static float _highScore;

    public static float HightScore { get { return _highScore; } }

    [SerializeField] TextMeshProUGUI _pointsref;

    void Awake()
    {
        _gamePoint = 0;
        _pointsref.text =  _gamePoint.ToString();
    }

    void Update()
    {
        float points = _gamePoint;
        if (_highScore < _gamePoint)
        {
            _highScore = points;
        }
        _pointsref.text = _gamePoint.ToString();
    }
}

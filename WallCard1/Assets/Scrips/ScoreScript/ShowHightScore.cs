using TMPro;
using UnityEngine;

public class ShowHightScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _HighScore;

    private float score;

    private void Update()
    {       
        Showhghtscore();
    }
    public void Showhghtscore()
    {
        score = SetPoints.HightScore;
        _HighScore.text = score.ToString();
    }
}

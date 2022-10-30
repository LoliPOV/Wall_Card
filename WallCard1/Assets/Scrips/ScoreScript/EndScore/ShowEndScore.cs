using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowEndScore : MonoBehaviour
{
    public TextMeshProUGUI _showScore;
    // Start is called before the first frame update
    void Start()
    {
        _showScore = GetComponent<TextMeshProUGUI>();
        _showScore.text = "Score: " + SetPoints._gamePoint.ToString();
    }   
}

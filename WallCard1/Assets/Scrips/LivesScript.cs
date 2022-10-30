using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class LivesScript : MonoBehaviour
{
    
    public static int lives = 3;
    public static bool CheckTrue;
    [SerializeField] GameObject PlayerConvas, EndConvas, SpawnTrigger;
    public TextMeshProUGUI _lives;


    void Start()
    {
        _lives = GetComponent<TextMeshProUGUI>();
        lives = 3;
        _lives.text = lives.ToString();
    }

    private void Update()
    {
        _lives = GetComponent<TextMeshProUGUI>();
        _lives.text = lives.ToString();
        if (lives <= 0)
        {
            lives = 0;
            EndConvas.SetActive(true);
            PlayerConvas.SetActive(false);
            SpawnTrigger.SetActive(false);
        }
    }
    
}

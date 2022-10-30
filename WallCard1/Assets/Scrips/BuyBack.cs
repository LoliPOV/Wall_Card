using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyBack : MonoBehaviour
{
    [SerializeField]
    private GameObject EndConvas, PlayerConvas, SpawnTrigger;
    [SerializeField]
    public bool _checked = false;
    public void DoBuyBack()
    {
        if (CoinS.totalcoins >= 100) 
        {
            LivesScript.lives = 3;
            EndConvas.SetActive(false);
            PlayerConvas.SetActive(true);
            SpawnTrigger.SetActive(true);
            _checked = true;
            CoinS.totalcoins -= 100;
        }
    }
}

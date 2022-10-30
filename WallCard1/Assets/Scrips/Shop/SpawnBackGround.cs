using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackGround : MonoBehaviour
{
    [SerializeField]
    private GameObject _standartBackGround;

    void Start()
    {
        CheckIsPurchased();
    }

    public void CheckIsPurchased()
    {
        if (SetBackGround._isSet == false)
        {
            Instantiate(_standartBackGround, new Vector3(-4.5f, -3, 6), Quaternion.identity);
        }
        else
        {
            Instantiate(SetBackGround._background, new Vector3(-4.5f, -3, 6), Quaternion.identity);
        }
    }
}

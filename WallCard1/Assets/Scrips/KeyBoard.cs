using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    public CubeRef _actionTarget;
    public BallRef _actionTarget2;
    public PyremidRef _actionTarget3;

    void Awake()
    {
        _actionTarget.GetComponent<CubeRef>();
        _actionTarget2.GetComponent<BallRef>();
        _actionTarget3.GetComponent<PyremidRef>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _actionTarget.onClick();
        }
          
        if (Input.GetKeyDown(KeyCode.E))
        {
            _actionTarget2.onClick();
        }
            
        if (Input.GetKeyDown(KeyCode.W))
        {
            _actionTarget3.onClick();
        }
    }

}

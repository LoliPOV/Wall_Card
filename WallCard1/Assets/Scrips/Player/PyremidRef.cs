using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyremidRef : MonoBehaviour
{
    public GameObject Pyramid;
    [SerializeField] GameObject _spawnPose;
    private GameObject Ball, Cube, cone;
    Vector3 spawnPose;
    private float _xPosition = -0.35f, _yPostion = 0.3f;
    
    private void Start()
    {

        spawnPose = new Vector3(_xPosition, _spawnPose.GetComponent<Transform>().position.y - _yPostion, _spawnPose.GetComponent<Transform>().position.z);
    }

    public void onClick()
    {
        Cube = GameObject.FindWithTag("CubePlayerT");
        Ball = GameObject.FindWithTag("BallPlayerT");
        cone = GameObject.FindWithTag("ConePlayerT");
        
        if (Ball)
        {
            Destroy(Ball);
        }
        else if (Cube)
        {
            Destroy(Cube);
        }
        if (!Pyramid)
        {
            Instantiate(Pyramid, spawnPose, Quaternion.identity);
        }
        else
        {
            Destroy(cone);
            Instantiate(Pyramid, spawnPose, Quaternion.identity);
        }
    }
}

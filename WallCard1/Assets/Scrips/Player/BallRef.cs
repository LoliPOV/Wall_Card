using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRef : MonoBehaviour
{
    public GameObject Ball;
    [SerializeField] GameObject _spawnPose;
    private GameObject Cone, Cube, ball;
    Vector3 spawnPose;
    

    private void Start()
    {
        
        spawnPose = new Vector3(0, _spawnPose.GetComponent<Transform>().position.y, _spawnPose.GetComponent<Transform>().position.z);
    }
    public void onClick()
    {
        Cube = GameObject.FindWithTag("CubePlayerT");
        Cone = GameObject.FindWithTag("ConePlayerT");
        ball = GameObject.FindWithTag("BallPlayerT");

        if (Cone)
        {
            Destroy(Cone);
        }
        else if (Cube)
        {
            Destroy(Cube);
        }
        if (!Ball)
        {
            Instantiate(Ball, spawnPose, Quaternion.identity);
        }
        else
        {
            Destroy(ball);
            Instantiate(Ball, spawnPose, Quaternion.identity);
        }
        
    }
}

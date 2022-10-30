using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRef : MonoBehaviour
{
    public GameObject Cube;
    [SerializeField] GameObject _spawnPose;
    private GameObject Ball, Cone, cube;
    Vector3 spawnPose;
    //private bool flag = false;
    

    private void Start()
    {
       
        spawnPose = new Vector3(0, _spawnPose.GetComponent<Transform>().position.y, _spawnPose.GetComponent<Transform>().position.z);
        Instantiate(Cube, spawnPose, Quaternion.identity);
    }
    public void onClick()
    {           
        Ball = GameObject.FindWithTag("BallPlayerT");      
        Cone = GameObject.FindWithTag("ConePlayerT");
        cube = GameObject.FindWithTag("CubePlayerT");
        

        if (Cone)
        {
            Destroy(Cone);
        }
        else if (Ball)
        {
            Destroy(Ball);
        }
        spawnPose = new Vector3(0, _spawnPose.GetComponent<Transform>().position.y, _spawnPose.GetComponent<Transform>().position.z);
        if (!Cube)
        {
            Instantiate(Cube, spawnPose, Quaternion.identity);
        }
        else
        {
            Destroy(cube);
            Instantiate(Cube, spawnPose, Quaternion.identity);
        }
    }
}

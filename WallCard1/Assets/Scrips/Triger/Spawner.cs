using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static bool flag;
    public GameObject WallPrefab1, WallPrefab2, WallPrefab3;
    private float _whatToSpawn;

    void Start()
    {
        flag = false;
    }
    void Update()
    {
        SpawnWall();
    }
    private void SpawnWall()
    {
        if (flag == true)
        {
            _whatToSpawn = Random.Range(1, 4);

            flag = false;
            Vector3 spawnPose = new Vector3(-0.35f, 0.65f, 10f);
            Vector3 spawnBallWallPose = new Vector3(-0.44f, 1f, 10f);

            switch (_whatToSpawn)
            {
                case 1:
                    Instantiate(WallPrefab1, spawnBallWallPose, Quaternion.Euler(-90, 180, 0));
                    break;
                case 2:
                    Instantiate(WallPrefab2, spawnPose, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(WallPrefab3, spawnPose, Quaternion.identity);
                    break;
            }

        }
    }
}
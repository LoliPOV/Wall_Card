using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelitTriger : MonoBehaviour
{

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DellTrigerT"))
        {
            MoveWall.SpeedValue++;
            Spawner.flag = true;
            Destroy(gameObject);                     
        }        
    }
}

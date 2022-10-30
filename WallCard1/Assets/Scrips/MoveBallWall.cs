using UnityEngine;

public class MoveBallWall : MoveWall
{
    private Rigidbody _rigidBody;
   
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        MovementLogic();       
    }

    private void MovementLogic()
    {
        _rigidBody.transform.Translate(new Vector3(0, Time.fixedDeltaTime * MoveWall.Speed, 0));       
    }
}

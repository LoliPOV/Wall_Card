using UnityEngine;

public class MoveWall : MonoBehaviour
{
    public static float Speed = -3.5f;
    private Rigidbody _rb;
    private float ChangeSpeed = -0.3f;
    public static float SpeedValue = 1;

    int _stopValue;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {       
        MovementLogic();

        if(SpeedValue % 5 == 0)
        {
            Speed += Time.fixedDeltaTime * ChangeSpeed;
            _stopValue++;
        }
        
    }  
    private void MovementLogic()
    {
        _rb.transform.Translate(new Vector3(0, 0, Time.fixedDeltaTime * Speed));
    }
}


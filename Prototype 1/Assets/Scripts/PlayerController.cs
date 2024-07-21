using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    
    private const float MoveSpeed = 15;
    private const float TurnSpeed = 100;
    
    private float _verticalInput;
    private float _horizontalInput;

    private void Update()
    {
        _verticalInput = Input.GetAxis(isPlayer1 ? "Vertical_P1" : "Vertical_P2");
        _horizontalInput = Input.GetAxis(isPlayer1 ? "Horizontal_P1" : "Horizontal_P2");
        
        // Time.deltaTime means the vehicle will move {MoveSpeed} meter per second
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * (MoveSpeed * _verticalInput * Time.deltaTime));
    }
}

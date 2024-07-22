using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
    }
}

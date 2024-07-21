using UnityEngine;

public class Bus : MonoBehaviour
{
    private const float Speed = 20f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * (Speed * Time.deltaTime));
    }
}

using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    private const float Speed = 10;
    
    private void Update()
    {
        transform.Rotate(-Vector3.forward, Speed);
    }
}

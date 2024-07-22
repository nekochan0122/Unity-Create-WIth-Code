using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public const float Bound = 20.0f;
    
    private void Update()
    {
        if (Mathf.Abs(transform.position.z) > Bound || Mathf.Abs(transform.position.x) > Bound)
        {
            Destroy(gameObject);

            if (gameObject.CompareTag("Animal"))
            {
                Debug.Log($"Game Over: {gameObject.name.Replace("(Clone)", "")} out of bound");
            }
        }
    }
}

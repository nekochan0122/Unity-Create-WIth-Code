using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public const float PlayerTopRange = 12f;
    public const float PlayerBottomRange = 0f;
    public const float PlayerXRange = 16f;
    
    private const float MoveSpeed = 30f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        var verticalInput = Input.GetAxis("Vertical");
        
        if (verticalInput < 0 && transform.position.z > PlayerBottomRange || verticalInput > 0 && transform.position.z < PlayerTopRange)
        {
            transform.Translate(Vector3.forward * (MoveSpeed * verticalInput * Time.deltaTime));
        }
        
        var horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput < 0 && transform.position.x > -PlayerXRange || horizontalInput > 0 && transform.position.x < PlayerXRange)
        {
            transform.Translate(Vector3.right * (MoveSpeed * horizontalInput * Time.deltaTime));
        }
    }
}

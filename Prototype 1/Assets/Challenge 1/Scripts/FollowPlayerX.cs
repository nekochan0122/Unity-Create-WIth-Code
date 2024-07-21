using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private readonly Vector3 _offset = new Vector3(20, 2, 10);

    private void LateUpdate()
    {
        transform.position = plane.transform.position + _offset;
    }
}

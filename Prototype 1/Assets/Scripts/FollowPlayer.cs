using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public bool isPlayer1;
    public GameObject player;
    
    private bool _isThirdPerson = true;
    private readonly Vector3 _thirdPersonPositionOffset = new Vector3(0, 4, -6);
    private readonly Vector3 _firstPersonPositionOffset = new Vector3(0, 2, 1.4f);

    private void Update()
    {
        var isPlayer1SwitchView = isPlayer1 && Input.GetKeyDown(KeyCode.V);
        var isPlayer2SwitchView = !isPlayer1 && Input.GetKeyDown(KeyCode.B);
        
        if (isPlayer1SwitchView || isPlayer2SwitchView)
        {
            _isThirdPerson = !_isThirdPerson;
        }
    }

    // use LateUpdate to ensure the camera moves after the player moved
    private void LateUpdate()
    {
        if (_isThirdPerson)
        {
            // Don't forget to reset rotation after switch back from first person view
            transform.position = player.transform.position + _thirdPersonPositionOffset;
            transform.rotation = Quaternion.Euler(20, 0, 0);
        }
        else
        {
            // use TransformDirection to get the correct offset from player
            transform.position = player.transform.position + player.transform.TransformDirection(_firstPersonPositionOffset);
            transform.rotation = player.transform.rotation;
        }
    }
}

using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private const float SpawnLimitXLeft = -22;
    private const float SpawnLimitXRight = 7;
    private const float SpawnPosY = 30;

    private const float StartDelay = 1.0f;
    private const float SpawnIntervalMin = 3.0f;
    private const float SpawnIntervalMax = 5.0f;

    // Start is called before the first frame update
    private void Start()
    {
        Invoke(nameof(SpawnRandomBall), StartDelay);
    }

    // Spawn random ball at random x position at top of play area
    private void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        var ballIndex = Random.Range(0, ballPrefabs.Length);
        var ballPrefab = ballPrefabs[ballIndex];
        var ballPosition = new Vector3(Random.Range(SpawnLimitXLeft, SpawnLimitXRight), SpawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefab, ballPosition, ballPrefab.transform.rotation);
        
        Invoke(nameof(SpawnRandomBall), Random.Range(SpawnIntervalMin, SpawnIntervalMax + 1));
    }

}

using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public enum Direction
    {
        Top,
        Left,
        Right
    }

    public Direction spawnDirection;
    public GameObject[] animalPrefabs;
    
    private const float StartDelay = 2;
    private const float SpawnInterval = 3f;
    private const float SpawnTopRange = PlayerController.PlayerTopRange - 2;
    private const float SpawnBottomRange = PlayerController.PlayerBottomRange + 2;
    private const float SpawnXRange = PlayerController.PlayerXRange;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), StartDelay, SpawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        var animalIndex = Random.Range(0, animalPrefabs.Length);
        var animalPrefab = animalPrefabs[animalIndex];
        
        Vector3 animalPosition;
        switch (spawnDirection)
        {
            case Direction.Top:
                animalPosition = new Vector3(Random.Range(-SpawnXRange, SpawnXRange), 0, DestroyOutOfBounds.Bound);
                Instantiate(animalPrefab, animalPosition, Quaternion.Euler(0, 180, 0));
                break;
            case Direction.Left:
                animalPosition = new Vector3(-DestroyOutOfBounds.Bound, 0, Random.Range(SpawnBottomRange, SpawnTopRange));
                Instantiate(animalPrefab, animalPosition, Quaternion.Euler(0, 90, 0));
                break;
            case Direction.Right:
                animalPosition = new Vector3(DestroyOutOfBounds.Bound, 0, Random.Range(SpawnBottomRange, SpawnTopRange));
                Instantiate(animalPrefab, animalPosition, Quaternion.Euler(0, -90, 0));
                break;
            default:
                throw new UnityException($"The direction is not support: {spawnDirection}");
        }
    }
}

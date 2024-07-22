using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<AnimalHunger>().FeedAnimal(1);
        }
        else if (other.CompareTag("Player"))
        {
            GameManager.Instance.Live--;
        }
        
    }
}

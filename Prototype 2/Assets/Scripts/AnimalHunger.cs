using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int _currentFedAmount;
    
    private void Start()
    {
        hungerSlider.value = 0;
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.fillRect.gameObject.SetActive(false);
    }
    
    public void FeedAnimal(int amount)
    {
        _currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = _currentFedAmount;

        if (_currentFedAmount >= amountToBeFed)
        {
            GameManager.Instance.Score++;
            Destroy(gameObject, 0.1f);
        }
    }
}

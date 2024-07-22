using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int _score;
    private int _live = 3;

    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            Debug.Log($"Score = {_score}");
        }
    }
    public int Live
    {
        get => _live;
        set
        {
            _live = value < 0 ? 0 : value;
            Debug.Log($"Live = {_live}");
            if (_live == 0) Debug.Log("Game Over: Live reaches 0");
        }
    }
    public static GameManager Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
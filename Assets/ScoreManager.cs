using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    public static ScoreManager instance;
    int _score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        if (_scoreText != null) { _scoreText.text = _score.ToString(); }
    }

    public void AddScore(int add)
    {
        _score += add;
        if (_scoreText != null) { _scoreText.text = _score.ToString(); }
        Debug.Log(_score);

    }
}

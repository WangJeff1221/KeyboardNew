using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;      

    public int score = 0;                
    public int lives = 3;                   
    public int winScore = 10;            

    public TextMeshProUGUI scoreText;      
    public TextMeshProUGUI lifeText;        
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateUI();
        if (score >= winScore)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    public void TakeDamage(int damage)
    {
        lives -= damage;
        UpdateUI();
        if (lives <= 0)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
        if (lifeText != null)
            lifeText.text = "Life:" + lives;
    }
}

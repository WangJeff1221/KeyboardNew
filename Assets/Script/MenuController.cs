using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}

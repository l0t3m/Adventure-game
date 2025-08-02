using TMPro;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
    [SerializeField] TextMeshProUGUI scoreText;

    public void GameOver(int score)
    {
        GameOverPanel.SetActive(true);
        scoreText.text = "Score: " + score;
    }
}

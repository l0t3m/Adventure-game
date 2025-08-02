using TMPro;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{
    [SerializeField] GameObject UIPanel;
    [SerializeField] TextMeshProUGUI scoreText;

    public void GameOver(int score)
    {
        UIPanel.SetActive(true);
        scoreText.text = "Score: " + score;
    }
}

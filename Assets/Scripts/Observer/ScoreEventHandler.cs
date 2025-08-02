using UnityEngine;

public class ScoreEventHandler : IEventListeners
{
    public void Execute(EventManager manager)
    {
        GameManager.Instance.scoreText.text = "Score: " + GameManager.Instance.Score;
    }
}

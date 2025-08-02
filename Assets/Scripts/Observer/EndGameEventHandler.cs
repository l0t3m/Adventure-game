using UnityEngine;

public class EndGameEventHandler : IEventListeners
{
    public void Execute(EventManager manager)
    {
        GameManager.Instance.IsPlaying = false;
        Object.FindAnyObjectByType<ShowGameOver>().GameOver(GameManager.Instance.Score);
    }  
}

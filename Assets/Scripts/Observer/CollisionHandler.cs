using UnityEngine;

public class CollisionHandler : IEventListeners
{
    public void Execute(EventManager manager)
    {
        if (manager is CollisionEventManager cem)
        {
            // if collision game object is pickup, increase score, call event, and spawn enemy and new pickup. 
            // also destroys the GO
            if (cem.CollisionGO.tag == "Pickup")
            {
                GameManager.Instance.Score += 1;
                GameManager.Instance.EventHandler.Notify("score_changed");
                Object.Destroy(cem.CollisionGO);
                
                Object.Instantiate(GameManager.Instance.PickupPrefab, GameManager.Instance.GetRandomPositionOnMap(), Quaternion.identity);
                Object.Instantiate(GameManager.Instance.EnemyPrefab, GameManager.Instance.GetRandomPositionOnMap(), Quaternion.identity);
            }
            // calls game end
            else if (cem.CollisionGO.tag == "Enemy")
            {
                GameManager.Instance.EventHandler.Notify("game_ended");
            }
        }
    }  
}

using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private PlayerManager player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // takes the player as soon as we spawn
        player = FindAnyObjectByType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if the game is playing, advance towards player
        if (GameManager.Instance.IsPlaying)
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 2.5f * Time.deltaTime);
    }
}

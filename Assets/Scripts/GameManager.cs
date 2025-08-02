using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EventManagersHandler EventHandler;
    public static GameManager Instance;
    public GameObject PickupPrefab;
    public GameObject EnemyPrefab;
    public TextMeshProUGUI scoreText;
    public bool IsPlaying = true;

    [HideInInspector] public int Score;
    [SerializeField] private BoxCollider2D mapObject;

    private void Awake()
    {
        Instance = this;
        EventHandler = new EventManagersHandler();
        // add events and handlers
        EventHandler.CreateEventManager("collision", new CollisionEventManager());
        EventHandler.CreateEventManager("score_changed", new EventManager());
        EventHandler.CreateEventManager("game_ended", new EventManager());

        EventHandler.Attach("collision", new CollisionHandler());
        EventHandler.Attach("score_changed", new ScoreEventHandler());
        EventHandler.Attach("game_ended", new EndGameEventHandler());
    }
 
    // gets a random position in the map square
    public Vector3 GetRandomPositionOnMap()
    {
        Bounds bounds = mapObject.bounds;

        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomY = Random.Range(bounds.min.y, bounds.max.y);

        return new Vector3(randomX, randomY, -1);
    }
}

using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= Vector3.up;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement -= Vector3.right;
        }

        transform.position += movement * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.EventHandler.DoLogic("collision", collision.gameObject);
        GameManager.Instance.EventHandler.Notify("collision");
    }
}

using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float speed;
  

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


    // assign the collided game object to the collision event, then call it
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.EventHandler.DoLogic("collision", collision.gameObject);
        GameManager.Instance.EventHandler.Notify("collision");
    }
}

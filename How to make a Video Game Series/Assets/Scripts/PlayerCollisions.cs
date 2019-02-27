using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            gameObject.GetComponent<Destructible>().Explode();
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }
}

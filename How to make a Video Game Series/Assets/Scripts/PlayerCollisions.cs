using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            GameObject.Find("Main Camera").GetComponent<CameraControl>().enabled = false;
            gameObject.GetComponent<Destructible>().Explode();
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }
}

using UnityEngine;

public class PlayerFalling : MonoBehaviour
{
    bool hasFallenAndCantGetUp = false;
    void FixedUpdate()
    {
        if (hasFallenAndCantGetUp)
        {
            Debug.Log("Help I've fallen and can't get up!");
        }
        else if(GameObject.FindGameObjectWithTag("Player").transform.position.y < -1.0f)
        {
            hasFallenAndCantGetUp = true;
            FindObjectOfType<GameManager>().EndGame();
            FindObjectOfType<AudioManager>().Play("PlayerFall");
        }
    }
}

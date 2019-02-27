using UnityEngine;

public class FlyTimeAbillity : MonoBehaviour
{
    public GameObject player;
    public GameObject ground;

    bool isFlyTimeActive = false;
    public float flyDuration = 1.0f;

    void FixedUpdate()
    {
        if (Mathf.Abs(player.transform.position.x) >= 8f)
        {
            if (isFlyTimeActive)
            {
            }
            else
            {
                ActivateFlyTime();
            }
        }

        if (Mathf.Abs(player.transform.position.x) < 8f)
        {
            if (isFlyTimeActive)
            {
                DeactivateFlyTime();
            }
            else
            {
            }
        }
    }

    private void ActivateFlyTime()
    {
        isFlyTimeActive = true;
        player.GetComponent<Rigidbody>().useGravity = false;
        Invoke("EndFlyTime", flyDuration);
    }

    private void DeactivateFlyTime()
    {
        isFlyTimeActive = false;
        player.GetComponent<Rigidbody>().useGravity = true;
    }

    private void EndFlyTime()
    {
        player.GetComponent<Rigidbody>().useGravity = true;
    }
}

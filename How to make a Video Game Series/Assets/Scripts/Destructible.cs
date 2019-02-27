using UnityEngine;

public class Destructible : MonoBehaviour
{

    public GameObject destroyedVersion;

    public void Explode()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        GameObject.Find("Main Camera").GetComponent<CameraControl>().enabled = false;
        Destroy(gameObject);
    }
}

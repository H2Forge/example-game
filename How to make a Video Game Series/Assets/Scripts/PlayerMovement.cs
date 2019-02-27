using UnityEngine.Audio;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    [Header("Movement Parameters")]
    public float forwardForce = 8000f;
    public float speed = 500f;
    public float flyTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        #region Movement
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement * speed * Time.deltaTime;

        rb.AddForce(movement,ForceMode.VelocityChange);

        #endregion

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

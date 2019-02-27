using UnityEngine.Audio;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    [Header("Movement Parameters")]
    public float forwardForce = 8000f;
    public float speed = 500f;

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");
    }

    #region SetMovement
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement * speed * Time.deltaTime;

        rb.AddForce(0, 0, forwardForce * Time.deltaTime,ForceMode.Acceleration);
        rb.AddForce(movement,ForceMode.VelocityChange);
    }
    #endregion
}

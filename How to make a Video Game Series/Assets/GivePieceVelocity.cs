using UnityEngine;

public class GivePieceVelocity : MonoBehaviour
{
    public Rigidbody[] pieces;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Rigidbody piece in pieces)
        {
            piece.velocity = new Vector3(0f, 100f, 0f);
        }
    }
}

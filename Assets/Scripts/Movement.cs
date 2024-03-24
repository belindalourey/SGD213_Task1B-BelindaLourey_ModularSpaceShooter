using UnityEngine;

public class Movement : MonoBehaviour
{
    // SerializeField exposes this value to the Editor, but not to other Scripts! 
    // Speed player moves horizontaly
    public float playerAcceleration = 5000f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // Get Rigidbody Component atached to the game object
        rb = GetComponent<Rigidbody2D>();
    }

    // Player horizontal movement
   public void HorizontalMovement(float HorizontalInput)
    {
        // force to the player moving left and right + acceleration  
        Vector2 force = Vector2.right * HorizontalInput * playerAcceleration * Time.deltaTime;
        rb.AddForce(force);
    }

}

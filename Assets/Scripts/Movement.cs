using UnityEngine;

public class Movement : MonoBehaviour
{
    // Speed set to 0 so its manualy entered in the inspector
    public float acceleration = 0f;

    // velocity starts at 2 so there is no lag
    private readonly float initialVelocity = 2f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // Get Rigidbody Component atached to the game object
        rb = GetComponent<Rigidbody2D>();
    }

    // Movement and speed of game objects
   public void Move(Vector2 directionInput)
    {
        // forceToAdd to the player moving + acceleration  
        Vector2 forceToAdd = initialVelocity * acceleration * Time.deltaTime * directionInput;

        rb.AddForce(forceToAdd);
    }
}


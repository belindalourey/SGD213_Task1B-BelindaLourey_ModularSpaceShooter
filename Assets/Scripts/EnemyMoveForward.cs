using UnityEngine;

public class EnemyMoveForward : MonoBehaviour 
{
    private readonly float acceleration = 75f;

    private readonly float initialVelocity = 2f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        // get the Rock/enemy 
        rb = GetComponent<Rigidbody2D>();
        // Moving the enemy in a downward direction
        rb.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Add force to the enemy, moving the enemy, down
        Vector2 ForceToAdd = acceleration * Time.deltaTime * Vector2.down;
        
        rb.AddForce(ForceToAdd);
    }
}

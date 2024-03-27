using UnityEngine;

public class BulletMoveForward : MonoBehaviour 
{
    private readonly float acceleration = 50f;

    private readonly float initialVelocity = 5f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Starting speed bullet moving up
        rb.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // Add force to the Bullet, up 
        Vector2 forceToAdd = acceleration * Time.deltaTime * Vector2.up;

        rb.AddForce(forceToAdd);
    }
}

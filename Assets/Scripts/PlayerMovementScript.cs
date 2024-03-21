using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
// SerializeField exposes this value to the Editor, but not to other Scripts! 
// Speed player moves horizontaly
[SerializeField]
private float PlayerAcceleration = 5000f;

private Rigidbody2D rb;

    // Use this for initialization
    void Start() 
    {
        // Get Rigidbody Component atached to the game object (player)
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update() 
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f) 
        {
            // force to the player moving left and right + acceleration + 
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*PlayerAcceleration*Time.deltaTime;
            rb.AddForce(ForceToAdd);
        } 
    } 
}

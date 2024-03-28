using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Movement movement;
    private Shoot shoot;
    
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        shoot = GetComponent<Shoot>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement Horizontal only
        float horizontalInput = Input.GetAxis("Horizontal");

        if(horizontalInput != 0.0f )
        {
            // Player horizontal input
            Vector2 direction = new(horizontalInput, 0);

            // Direction movement
            movement.Move(direction);
        }
        
        // Left mouse click to fire/shoot laser
        if (Input.GetButton("Fire1"))
        {
            if (shoot != null)
            {
                shoot.Fire();
            }
            else
            {
                // If shoot/fire is not active debug log
                Debug.Log("Attach the shoot script");
            }
        }
    }
}

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
        float HorizontalInput = Input.GetAxis("Horizontal");

        if(HorizontalInput != 0.0f )
        {
            movement.HorizontalMovement(HorizontalInput);
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
                Debug.Log("Attach the shoot script");
            }
        }
    }

}
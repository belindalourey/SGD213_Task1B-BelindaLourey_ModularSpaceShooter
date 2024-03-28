using UnityEngine;

public class BulletMove : MonoBehaviour 
{
    private Movement movement;

    // Use this for initialization
    void Start()
    {
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {   
        // Bullet movement up axis(x0 - y1)
        Vector2 direction = new(0, 1);

        // Direction movement
        movement.Move(direction);  
    }
}

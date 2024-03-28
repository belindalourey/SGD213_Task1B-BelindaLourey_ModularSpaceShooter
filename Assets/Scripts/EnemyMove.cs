using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Movement movement;

    // Use this for initialization
    void Start()
    {
        // Use movement script
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        // enemy moving down axis(x0 y-1)
        Vector2 direction = new(0, -1);

        // Direction movement
        movement.Move(direction);
    }
}

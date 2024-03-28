using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        // Spawn bullets in front of the player using maths to get location
        bulletOffset = (GetComponent<Renderer>().bounds.size.y / 2) + (bullet.GetComponent<Renderer>().bounds.size.y / 2);
    }

    public void Fire()
    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            // bullett spawn location
            Vector2 spawnPosition = new(transform.position.x, transform.position.y + bulletOffset);

            Instantiate(bullet, spawnPosition, transform.rotation);

            // shoot/fire timer 
            lastFiredTime = CurrentTime;
        }
    }
}
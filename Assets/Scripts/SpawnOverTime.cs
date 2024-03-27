using UnityEngine;

public class SpawnOverTime : MonoBehaviour
{
    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer newRenderer;

    // Use this for initialization
    void Start()
    {
        newRenderer = GetComponent<Renderer>();

        // Stop Spawner from being visible!
        newRenderer.enabled = false;

        // SpawnDelay so enemys can only come out slowly 
        InvokeRepeating(nameof(Spawn), spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        // Enemy spawn location in the boundry
        float min = transform.position.x - newRenderer.bounds.size.x / 2;
        float max = transform.position.x + newRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new(Random.Range(min, max), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}

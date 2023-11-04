using UnityEngine;

public class DestinationIndicator : MonoBehaviour
{
    private Transform player; // Reference to the player character.
    private bool isPlaced = false;

    void Start()
    {
        // Find and reference the player character. You can do this programmatically or in the Inspector.
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (isPlaced)
        {
            // Check the distance between the indicator and the player character.
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            
            // You can adjust the threshold for removal as needed.
            if (distanceToPlayer < 0.75f)
            {
                // Remove the indicator when the player reaches the destination.
                RemoveIndicator();
            }
        }
    }

    public void PlaceIndicator(Vector3 position)
    {
        transform.position = position;
        isPlaced = true;
        
    }

    private void RemoveIndicator()
    {
        // Remove the indicator by disabling it or destroying it.
        Destroy(gameObject); // Destroying the GameObject.
    }
}

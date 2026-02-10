using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject checkpointEffect;
    public bool isActive = false;
    
    void Start()
    {
        // Initial setup if needed
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Logic for what happens when the player reaches the checkpoint
            ActivateCheckpoint();
        }
    }
    
    void ActivateCheckpoint()
    {
        if (!isActive)
        {
            isActive = true;
            Instantiate(checkpointEffect, transform.position, Quaternion.identity);
            // Save the player's checkpoint position, can be added later
            Debug.Log("Checkpoint Activated!");
        }
    }
}
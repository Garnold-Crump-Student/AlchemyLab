using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    // Set the scene name you want to load
    public string sceneToLoad = "TitleScreen"; // Replace with the scene you want to load

    // Define the distance at which the player can interact with the door
    public float interactionDistance = 3f;

    // Reference to the player's position
    private Transform player;

    private void Start()
    {
        // Get the player's transform (assuming the player has a tag "Player")
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Check if the player presses the "E" key and is within range
        if (Vector3.Distance(player.position, transform.position) <= interactionDistance && Input.GetKeyDown(KeyCode.E))
        {
            LoadScene();
        }
    }

    // Method to load the scene
    void LoadScene()
    {
        // Check if the scene exists in the build settings
        if (Application.CanStreamedLevelBeLoaded(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogError("Scene not found: " + sceneToLoad);
        }
    }
}

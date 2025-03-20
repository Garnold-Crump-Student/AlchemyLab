using UnityEngine;

public class TurnObject : MonoBehaviour
{
    [SerializeField] private float modifiedScale = 2f; // Can scale the rotation
    [SerializeField] private float changeRate = 5f; // Speed of rotation
    private Vector3 initialRotate; // Starting rotation
    private bool isRotated = false; // To toggle rotation

    void Start()
    {
        // Set the initial rotation as the current rotation when the game starts
        initialRotate = transform.eulerAngles;
    }

    void Update()
    {
        // Smoothly rotate from current rotation to the target rotation
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(GetTargetRotate()), changeRate * Time.deltaTime);
    }

    private Vector3 GetTargetRotate()
    {
        // If isRotated is true, return modified rotation; otherwise, return initial rotation
        return isRotated ? initialRotate * modifiedScale : initialRotate;
    }

    public void ToggleOn()
    {
        // Toggle rotation state
        isRotated = !isRotated;
    }
}
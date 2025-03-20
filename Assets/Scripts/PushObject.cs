
using UnityEngine;
[RequireComponent (typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Push(float strength)
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rb.AddForce (pushDirection * strength, ForceMode.Impulse);
    }
}

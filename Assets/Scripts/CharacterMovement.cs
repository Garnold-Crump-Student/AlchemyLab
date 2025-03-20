using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 5f;
    private Vector3 moveDirection;

    void Start()
    {
        controller= GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       
        moveDirection.Normalize();
        moveDirection.y = -1f;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

    }
    public void AddMoveInput( float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

         moveDirection = (forward * forwardInput) + (rightInput * right);
    }
}

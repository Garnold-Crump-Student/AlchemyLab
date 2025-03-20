using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCam firstPersonCam;
    CharacterMovement characterMovement;
    PlayerInteractions playerInteraction;
    void Start()
    {
        firstPersonCam = GetComponent<FirstPersonCam>();
        characterMovement = GetComponent<CharacterMovement>();
        playerInteraction = GetComponent<PlayerInteractions>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamInput();
        HandleMoveInput();
        HandleInteractionInput();
    }
    void HandleCamInput()
    {
        firstPersonCam.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCam.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }
    void HandleMoveInput()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

            characterMovement.AddMoveInput(forwardInput, rightInput);
    }
    void HandleInteractionInput()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            playerInteraction.TryInteract();
        }
    }
}

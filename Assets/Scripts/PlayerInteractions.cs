using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInteractions : MonoBehaviour
{
   [SerializeField] private float maxDistance = 2f;
[SerializeField]    private Text interactableName;
    public float jumpForce = 5f;
    public bool isFalling = true;
    private InteractionObject targetInteraction;
    

    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 vector3 = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;
        if(Physics.Raycast(origin, vector3, out raycastHit, maxDistance))
        {
          
           targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
         
        }
        if (targetInteraction && targetInteraction.enabled)
        {
            interactionText = targetInteraction.GetInteractionText();
        }

        SetInteractbleNameText(interactionText);


    }
    private void SetInteractbleNameText(string newText)
    {
        if(interactableName)
        {
            interactableName.text = newText;
        }
    }
    public void TryInteract()
    {
        if (targetInteraction && targetInteraction.enabled)
        {
            targetInteraction.Interact();
        }
    }
}

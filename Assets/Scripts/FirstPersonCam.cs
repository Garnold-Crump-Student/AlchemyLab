using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    private float xAxis;
    private float yAxis;

    float xAxisSpeed =360f;
    float yAxisSpeed = 360f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        Cursor.lockState= CursorLockMode.None;
    }
    void LateUpdate()
    { 
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }
    public void AddXAxisInput(float input)
    {
        
        xAxis -= input * xAxisSpeed ;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }
    public void AddYAxisInput(float input)
    {
        yAxis -= input * yAxisSpeed ;
    }

}

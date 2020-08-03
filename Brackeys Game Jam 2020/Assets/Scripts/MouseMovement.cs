using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Transform playerRotate;
    public float mouseSensitivity = 50f;
    float xRotator = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXAxis = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseYAxis = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        
        xRotator -= mouseYAxis;
        xRotator = Mathf.Clamp(xRotator, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotator, 0f, 0f);
        playerRotate.Rotate(Vector3.up * mouseXAxis);
    }
}

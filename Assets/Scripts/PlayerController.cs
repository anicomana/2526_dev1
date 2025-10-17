using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float verticalSpeed = 20.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput );

        // Turn the vehicle 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}

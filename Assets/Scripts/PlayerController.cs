using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float verticalSpeed = 20.0f;
    public float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 lastPosition;

    [Header("Jump")]
    public float jumpVelocity = 6.5f;
    public float groundCheckDistance = 0.9f;
    private float jumpInput;

    Rigidbody rb;

    // Awake is called when the script instance is being loaded
    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("PlayerController: Rigidbody component not found.");
        }

        lastPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * verticalInput );

        // Turn the vehicle
        Vector3 deltaPosition = transform.position - lastPosition;
        lastPosition = transform.position;

        if (deltaPosition != Vector3.zero || !IsGrounded())
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }
        

        Debug.Log("isGrounded? " + IsGrounded());

        // Jump the vehicle
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            var originalVelocity = rb.linearVelocity;

            rb.linearVelocity = new Vector3(originalVelocity.x, jumpVelocity, originalVelocity.z);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
    }
}

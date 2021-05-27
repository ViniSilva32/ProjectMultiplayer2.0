using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    private CharacterController controller;
   
     
    [SerializeField]
    public float speed = 8f;
    
    [SerializeField]
    public float lookSensivity = 3f;
    
    [SerializeField]
    GameObject fpsCamera;

    public float JumpForce;
    public CapsuleCollider col;
    public LayerMask GroundLayers;

    private Vector3 velocity = Vector3.zero;
    private Vector3 rotations = Vector3.zero;

    private Rigidbody rb;

    private float CameraRotation = 0f;
    private float currentCameraRotation = 0f;
    

    
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        Vector3 movementHorizontal = transform.right * xMovement;
        Vector3 movementVertical = transform.forward * zMovement;

        Vector3 movementVelocity = (movementHorizontal + movementVertical).normalized * speed;
        
            Move(movementVelocity);

        if ( IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        float yRotation = Input.GetAxis("Mouse X");
        Vector3 rotationVector = new Vector3(0, yRotation, 0) * lookSensivity;

        Rotate(rotationVector);

        float CameraRotation = Input.GetAxis("Mouse Y") * lookSensivity;


        RotateCamera(CameraRotation);
    }
    private bool IsGrounded() => Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, 
        col.bounds.center.z), col.radius * 12f, GroundLayers);

    void Move(Vector3 movementVelocity)
    {
        velocity = movementVelocity;
    }

    void Rotate(Vector3 rotationVector)
    {
        rotations = rotationVector;
    }

    private void FixedUpdate()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotations));
        if(fpsCamera != null)
        {
            currentCameraRotation -= CameraRotation;
            currentCameraRotation = Mathf.Clamp(currentCameraRotation, 0, 0); 
        }
    }

    void RotateCamera(float cameraRotation)
    {
        CameraRotation = cameraRotation;
    }
}



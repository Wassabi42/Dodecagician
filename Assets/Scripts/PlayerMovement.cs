using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float movementX;
    private float movementY;
    [SerializeField] private float movementSpeed;

    [SerializeField] Transform orbTransform;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();

        orbTransform = GetComponent<Transform>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        playerRigidbody.AddForce(movement * movementSpeed);
    }
}

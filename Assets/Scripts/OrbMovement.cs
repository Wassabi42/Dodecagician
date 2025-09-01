using UnityEngine;
using UnityEngine.InputSystem;

public class OrbMovement : MonoBehaviour
{
    [SerializeField] Transform pTransform;
    private Rigidbody orbRigidbody;
    private float movementX;
    private float movementY;

    [SerializeField] private float movementSpeed;

    void Start()
    {
        transform.position = pTransform.position;
        orbRigidbody = GetComponent<Rigidbody>();
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

        orbRigidbody.AddForce(movement * movementSpeed);
    }
}

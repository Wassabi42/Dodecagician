using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    InputAction spaceAction;

    [SerializeField] Transform playerPosition;
    [SerializeField] Transform orbPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        spaceAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (spaceAction.WasPerformedThisFrame())
        {
            Swap();
        }
    }

    void Swap()
    {
        Vector3 tempPosition = playerPosition.position;
        playerPosition.position = orbPosition.position;
        orbPosition.position = tempPosition;
    }
}

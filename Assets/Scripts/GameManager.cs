using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] ParticleSystem teleportParticles;

    InputAction spaceAction;

    [SerializeField] Transform playerPosition;
    [SerializeField] Transform orbPosition;

    void Awake()
    {
        spaceAction = InputSystem.actions.FindAction("Jump");
    }

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
        teleportParticles.Play();
    }
}

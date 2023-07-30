using UnityEngine;
using UnityEngine.InputSystem;

public class GrapplingHook : MonoBehaviour
{
    public float hookLength = 18f;
    public float pullSpeed = 10f; // New variable for controlling the pull speed
    public LayerMask hookMask;
    public Camera playerCamera; // Reference to the player's camera

    private Vector3 hookTarget;
    private bool isHooked;
    private PlayerControls controls; // New Input System
    private CharacterController characterController;

    private void Awake()
    {
        controls = new PlayerControls();
        characterController = GetComponent<CharacterController>();

        controls.Gameplay.Hook.performed += ctx => ToggleHook(); // Assuming 'Hook' is the action you set for grappling hook
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    void ToggleHook()
    {
        if (isHooked)
        {
            ReleaseHook();
        }
        else
        {
            AttemptHook();
        }
    }

    void AttemptHook()
    {
        RaycastHit hit;
        // Use the camera's forward direction for the Raycast
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, hookLength, hookMask))
        {
            hookTarget = hit.point;
            isHooked = true;
            characterController.enabled = false; // Disable the character controller
            // Rotate the character to face the hook point immediately
            transform.LookAt(hookTarget);
        }
    }

    void ReleaseHook()
    {
        isHooked = false;
        characterController.enabled = true; // Enable the character controller
    }

    void Update()
    {
        if (isHooked)
        {
            Vector3 hookDir = hookTarget - transform.position;
            // Multiply the direction by the pull speed
            transform.position = Vector3.MoveTowards(transform.position, hookTarget, pullSpeed * Time.deltaTime);
            // Rotate the character to face the hook point
            Quaternion toRotation = Quaternion.LookRotation(hookDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 360 * Time.deltaTime);
        }
    }
}
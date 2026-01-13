using UnityEngine;
using UnityEngine.InputSystem;

public class IB_VerticalFlight : MonoBehaviour
{
    public InputActionReference verticalMoveAction; // joystick droit (Vector2)
    public CharacterController characterController;

    public float verticalSpeed = 2.5f;
    public float minAltitude = 10f;
    public float maxAltitude = 800f;

    void OnEnable() => verticalMoveAction?.action?.Enable();
    void OnDisable() => verticalMoveAction?.action?.Disable();

    void Update()
    {
        if (characterController == null || verticalMoveAction == null) return;

        Vector2 input = verticalMoveAction.action.ReadValue<Vector2>();
        float y = input.y;

        if (Mathf.Abs(y) < 0.1f) return;

        Vector3 move = Vector3.up * y * verticalSpeed * Time.deltaTime;

        float nextY = transform.position.y + move.y;
        if (nextY < minAltitude) move.y = minAltitude - transform.position.y;
        if (nextY > maxAltitude) move.y = maxAltitude - transform.position.y;

        characterController.Move(move);
    }
}
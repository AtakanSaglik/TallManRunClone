using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float verticalMovementSpeed;
    private float newPositionZ;
    private float newPositionX;
    private Vector3 newPosition;
    private Vector3 newPositionRot;

    [SerializeField] public bool rotated;



    private void FixedUpdate()
    {
        if (!rotated)
        {
            SetVerticalMovement();

        }
        if (rotated)
        {
            SetVerticalMovementRot();

        }

    }

    private void SetVerticalMovement()
    {

        newPositionZ = Mathf.Clamp(transform.position.z - playerInputController.VerticalValue * verticalMovementSpeed * Time.fixedDeltaTime,-4.6f,4.6f);
        newPosition = new Vector3(transform.position.x, transform.position.y, newPositionZ);
        transform.position = Vector3.Lerp(transform.position, newPosition, 0.1f);
    }
    private void SetVerticalMovementRot()
    {

        newPositionX = Mathf.Clamp(transform.position.x - playerInputController.VerticalValue * verticalMovementSpeed * Time.fixedDeltaTime,98.6f,108f);
        newPositionRot = new Vector3(newPositionX, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPositionRot, 0.1f);
    }


}

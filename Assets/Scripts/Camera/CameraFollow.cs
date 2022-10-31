using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public Vector3 offset;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float LerpValue;
    [SerializeField] public Change change;


    void Start()
    {
        offset = transform.position - playerTransform.position;

    }

    void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(playerTransform.position.x, 0f, playerTransform.position.z) + offset, LerpValue * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, change.current ,0.05f);

        //transform.LookAt(playerTransform);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    private bool isChanged;
    private GameObject mainBody;
    private GameObject mainCamera;
    [SerializeField] public CameraFollow cameraFollow;
    [SerializeField] public PlayerMoveController playerMoveController;
    Quaternion target1 = Quaternion.Euler(24, 90, 0);
    Quaternion target2 = Quaternion.Euler(24, 180, 0);
    [SerializeField] public Quaternion current;



    void Start()
    {
        mainBody = GameObject.FindGameObjectWithTag("MainPlayer");
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        isChanged = false;
        current = target1;
        
    }



    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainPlayer" && !isChanged)
        {
            isChanged = true;
            mainBody.transform.rotation=Quaternion.Lerp(mainBody.transform.rotation,Quaternion.Euler(0,180,0),1f);
            cameraFollow.offset = new Vector3(0f, 8f, 12f);
            //mainCamera.transform.rotation = Quaternion.Lerp(mainBody.transform.rotation, Quaternion.Euler(90, 180, 0), 0.1f);
            ChangeCurrentAngle();
            playerMoveController.rotated = true;

        }
    }

    private void ChangeCurrentAngle()
    {
        current = target2;
    }

}

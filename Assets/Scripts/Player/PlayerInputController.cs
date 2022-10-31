using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    private float verticalValue;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private Camera mainCamera;
    Animator animationCont;

    public float VerticalValue
    {
        get { return verticalValue; }
    }

    void Start()
    {
        animationCont = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touching = Input.GetTouch(0);

            if (touching.phase == TouchPhase.Stationary || touching.phase == TouchPhase.Moved)
            {
                animationCont.SetBool("isRunning", true);
                transform.Translate(Vector3.forward * forwardMovementSpeed * Time.deltaTime);
            }

            if (touching.phase == TouchPhase.Moved)
            {
                verticalValue = touching.deltaPosition.x;


            }

            if (touching.phase == TouchPhase.Ended || touching.phase == TouchPhase.Stationary)
            {
                verticalValue = 0f;

            }
            if (touching.phase == TouchPhase.Ended)
            {
                animationCont.SetBool("isRunning", false);

            }

        }
        

    }


}

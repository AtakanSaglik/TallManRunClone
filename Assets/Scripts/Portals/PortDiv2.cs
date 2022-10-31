using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortDiv2 : MonoBehaviour
{
    private bool isCrashed;
    private GameObject mainBody;
    private float newScale;


    void Start()
    {
        isCrashed = false;
        mainBody = GameObject.FindGameObjectWithTag("MainPlayer");


    }

    void Update()
    {
        newScale = mainBody.transform.localScale.y;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainPlayer" && !isCrashed)
        {
            isCrashed = true;
            newScale = newScale / 1.3f;
            mainBody.transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }


}

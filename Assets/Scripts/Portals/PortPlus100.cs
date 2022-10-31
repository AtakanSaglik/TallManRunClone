using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortPlus100 : MonoBehaviour
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
            newScale += 0.8f;
            mainBody.transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }


}

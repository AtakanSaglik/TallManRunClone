using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectText : MonoBehaviour
{
    Animator textanimator;


    void Start()
    {
        textanimator = gameObject.GetComponent<Animator>();
        textanimator.SetBool("collected1", true);

    }

    void Update()
    {


    }

    public void startingcoroutine()
    {
        gameObject.SetActive(true);
        StartCoroutine(textobjefade());

    }

    public IEnumerator textobjefade()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}

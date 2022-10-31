using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollector : MonoBehaviour
{
    private bool isCollected;
    private GameObject Player;
    [SerializeField] private Score score;
    [SerializeField] private CollectText collectText;


    void Start()
    {
        isCollected = false;
        Player = GameObject.FindGameObjectWithTag("MainPlayer");

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainPlayer" && !isCollected)
        {
            isCollected = true;
            collectText.startingcoroutine();
            Destroy(gameObject);
            score.pointScore+=10f;
        }
    }



}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public float pointScore;

    


    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        scoreText.text = "Score:" + pointScore;

    }
}
